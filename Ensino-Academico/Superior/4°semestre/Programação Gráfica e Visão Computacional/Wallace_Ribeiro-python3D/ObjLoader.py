import numpy as np
#--------------------------------------------------------------------------------------------------------------
class ObjLoader:
    @staticmethod
    def load_model(file_path):
        vertices = []
        textures = []
        normals = []
        vertex_data = []
        indices = []
        # --------------------------------------------------------------------------------------------------------------
        with open(file_path, 'r', encoding='utf-8') as file:
            for line in file:
                if line.startswith('v '):
                    parts = line.strip().split()[1:]
                    vertices.append([float(x) for x in parts])
                elif line.startswith('vt '):
                    parts = line.strip().split()[1:]
                    textures.append([float(x) for x in parts])
                elif line.startswith('vn '):
                    parts = line.strip().split()[1:]
                    normals.append([float(x) for x in parts])
                elif line.startswith('f '):
                    face = line.strip().split()[1:]
                    for part in face:
                        v, t, n = [int(i) - 1 for i in part.split('/')]
                        vertex_data.extend(vertices[v] + textures[t] + normals[n])
                        indices.append(len(indices))
        # --------------------------------------------------------------------------------------------------------------
        buffer = np.array(vertex_data, dtype=np.float32)
        indices = np.array(indices, dtype=np.uint32)
        return indices, buffer
