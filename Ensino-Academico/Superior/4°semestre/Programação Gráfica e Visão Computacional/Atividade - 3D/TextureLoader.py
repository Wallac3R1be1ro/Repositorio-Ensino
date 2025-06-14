# TextureLoader.py

from PIL import Image
from OpenGL.GL import *

def load_texture(path, texture_id):
    glBindTexture(GL_TEXTURE_2D, texture_id)

    image = Image.open(path)
    image = image.transpose(Image.FLIP_TOP_BOTTOM)  # OpenGL espera as imagens de cabeça para baixo
    img_data = image.convert("RGBA").tobytes()

    glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, image.width, image.height,
                 0, GL_RGBA, GL_UNSIGNED_BYTE, img_data)
    glGenerateMipmap(GL_TEXTURE_2D)

    # Parâmetros padrão da textura
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT)
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT)
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR_MIPMAP_LINEAR)
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR)
