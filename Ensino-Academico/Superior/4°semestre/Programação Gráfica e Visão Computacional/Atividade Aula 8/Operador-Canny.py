import cv2
import numpy as np
import matplotlib.pyplot as plt

# Carrega as imagens: colorida e em escala de cinza
image_color = cv2.imread('img-perfil.png')
image_gray = cv2.imread('img-perfil.png', 0)

# Verificação de carregamento
if image_color is None or image_gray is None:
    print("Erro ao carregar a imagem. Verifique o caminho ou o nome do arquivo.")
    exit()

# Aplica o detector de bordas Canny
edges = cv2.Canny(image_gray, 100, 200)

# Criação da figura
plt.figure(figsize=(14, 5))

# Imagem original em escala de cinza
plt.subplot(1, 3, 1)
plt.imshow(image_gray, cmap='gray')
plt.title('Imagem Original (Cinza)')
plt.axis('off')

# Imagem com detecção de bordas
plt.subplot(1, 3, 2)
plt.imshow(edges, cmap='gray')
plt.title('Bordas - Canny')
plt.axis('off')

# Divide a imagem original e substitui parte pela imagem de bordas
limiar = 130
sub_image1 = image_color[:, :limiar]  # Primeira parte (colorida)
sub_image2 = cv2.cvtColor(edges[:, limiar:], cv2.COLOR_GRAY2BGR)  # Segunda parte (bordas convertidas p/ BGR)
imagem_combinada = np.concatenate((sub_image1, sub_image2), axis=1)

# Exibe a imagem combinada
plt.subplot(1, 3, 3)
plt.imshow(cv2.cvtColor(imagem_combinada, cv2.COLOR_BGR2RGB))
plt.title('Combinação (Cor + Bordas)')
plt.axis('off')

# Mostra tudo
plt.tight_layout()
plt.show()
