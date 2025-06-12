import cv2
import numpy as np
import matplotlib.pyplot as plt

# Carrega a imagem
image = cv2.imread('img-perfil.png')

# Verifica se a imagem foi carregada corretamente
if image is None:
    print("Erro ao carregar a imagem. Verifique o caminho ou o nome do arquivo.")
    exit()

# Converte para escala de cinza
gray_image = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

# Aplica desfoque Gaussiano para reduzir ruído
kernel_size = 5
blurred_gray = cv2.GaussianBlur(gray_image, (kernel_size, kernel_size), 0)

# Define os thresholds para o detector de bordas Canny
low_threshold = 100
high_threshold = 200
edges = cv2.Canny(blurred_gray, low_threshold, high_threshold)

# Exibe o resultado
plt.figure(figsize=(16, 7))
plt.imshow(edges, cmap='gray', vmin=0, vmax=255)
plt.title('Detecção de Bordas - Canny')
plt.axis('off')
plt.show()
