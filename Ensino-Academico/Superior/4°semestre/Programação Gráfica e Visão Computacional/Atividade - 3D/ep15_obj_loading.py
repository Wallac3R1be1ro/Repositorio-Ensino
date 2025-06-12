import glfw
from OpenGL.GL import *
from OpenGL.GL.shaders import compileProgram, compileShader
import pyrr
from TextureLoader import load_texture
from ObjLoader import ObjLoader
indices, buffer = ObjLoader.load_model("Mamute.obj")
from pyglet.gl import GL_VERTEX_SHADER, GL_FRAGMENT_SHADER

# Shaders
vertex_src = """
# version 330
layout(location = 0) in vec3 a_position;
layout(location = 1) in vec2 a_texture;
layout(location = 2) in vec3 a_normal;

uniform mat4 model;
uniform mat4 projection;
uniform mat4 view;

out vec2 v_texture;

void main()
{
    gl_Position = projection * view * model * vec4(a_position, 1.0);
    v_texture = a_texture;
}
"""

fragment_src = """
# version 330
in vec2 v_texture;
out vec4 out_color;
uniform sampler2D s_texture;

void main()
{
    out_color = texture(s_texture, v_texture);
}
"""

def window_resize(window, width, height):
    glViewport(0, 0, width, height)
    projection = pyrr.matrix44.create_perspective_projection_matrix(45, width / height, 0.1, 100)
    glUniformMatrix4fv(proj_loc, 1, GL_FALSE, projection)

# Inicializa GLFW
if not glfw.init():
    raise Exception("GLFW não pôde ser iniciado")

window = glfw.create_window(1280, 720, "Modelo 3D", None, None)
if not window:
    glfw.terminate()
    raise Exception("Janela GLFW não pôde ser criada")

glfw.set_window_pos(window, 100, 100)
glfw.set_window_size_callback(window, window_resize)
glfw.make_context_current(window)

# Carrega o modelo 3D
indices, buffer = ObjLoader.load_model("Mamute.obj")

# Compila shaders
shader = compileProgram(
    compileShader(vertex_src, GL_VERTEX_SHADER),
    compileShader(fragment_src, GL_FRAGMENT_SHADER)
)

# Cria VAO/VBO
VAO = glGenVertexArrays(1)
VBO = glGenBuffers(1)

glBindVertexArray(VAO)
glBindBuffer(GL_ARRAY_BUFFER, VBO)
glBufferData(GL_ARRAY_BUFFER, buffer.nbytes, buffer, GL_STATIC_DRAW)

# Posição
glEnableVertexAttribArray(0)
glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, buffer.itemsize * 8, ctypes.c_void_p(0))
# Textura
glEnableVertexAttribArray(1)
glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, buffer.itemsize * 8, ctypes.c_void_p(12))
# Normais
glEnableVertexAttribArray(2)
glVertexAttribPointer(2, 3, GL_FLOAT, GL_FALSE, buffer.itemsize * 8, ctypes.c_void_p(20))

# Textura
texture = glGenTextures(1)
load_texture("Pele.png", texture)

# Setup geral
glUseProgram(shader)
glClearColor(0.1, 0.1, 0.1, 1)
glEnable(GL_DEPTH_TEST)

projection = pyrr.matrix44.create_perspective_projection_matrix(45, 1280 / 720, 0.1, 100)
view = pyrr.matrix44.create_look_at(
    eye=pyrr.Vector3([0, 0, -5]),  # mais perto do objeto
    target=pyrr.Vector3([0, 0, 0]),
    up=pyrr.Vector3([0, 1, 0])
)
model_translation = pyrr.matrix44.create_from_translation(pyrr.Vector3([0, 0, -3]))



# Uniform locations
model_loc = glGetUniformLocation(shader, "model")
proj_loc = glGetUniformLocation(shader, "projection")
view_loc = glGetUniformLocation(shader, "view")

glUniformMatrix4fv(proj_loc, 1, GL_FALSE, projection)
glUniformMatrix4fv(view_loc, 1, GL_FALSE, view)

# Loop principal
while not glfw.window_should_close(window):
    glfw.poll_events()
    glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT)

    rotation = pyrr.Matrix44.from_y_rotation(0.8 * glfw.get_time())
    model = pyrr.matrix44.multiply(rotation, model_translation)

    glBindVertexArray(VAO)
    glBindTexture(GL_TEXTURE_2D, texture)
    glUniformMatrix4fv(model_loc, 1, GL_FALSE, model)
    glDrawArrays(GL_TRIANGLES, 0, len(indices))

    glfw.swap_buffers(window)

glfw.terminate()
