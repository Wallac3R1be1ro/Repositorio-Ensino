import cv2
import numpy as np
import matplotlib.pyplot as plt

# Carrega a imagem
img = cv2.imread('img-perfil.png')

# Verifica se a imagem foi carregada corretamente
if img is None:
    print("Erro ao carregar a imagem. Verifique o caminho do arquivo.")
    exit()

# Converte para escala de cinza
img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Calcula o gradiente sobel nas direções X e Y
sobelX = cv2.Sobel(img_gray, cv2.CV_64F, 1, 0)
sobelY = cv2.Sobel(img_gray, cv2.CV_64F, 0, 1)

# Converte os gradientes para valores absolutos de 8 bits
sobelX = np.uint8(np.absolute(sobelX))
sobelY = np.uint8(np.absolute(sobelY))

# Combina os gradientes usando operação OR bit a bit
sobel = cv2.bitwise_or(sobelX, sobelY)

# Empilha as imagens para visualização
resultado = np.vstack([
    np.hstack([img_gray, sobelX]),
    np.hstack([sobelY, sobel])
])

# Exibe usando matplotlib
plt.figure(figsize=(16, 7))
plt.imshow(resultado, cmap='gray')
plt.title('Sobel')
plt.axis('off')
plt.show()
