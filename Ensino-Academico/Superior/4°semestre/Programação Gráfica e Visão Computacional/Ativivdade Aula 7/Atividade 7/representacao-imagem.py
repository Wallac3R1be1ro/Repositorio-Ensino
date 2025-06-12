import cv2
import numpy as np

# Carrega a imagem em escala de cinza (0)
img = cv2.imread('img-perfil.png', 0)

# Verifica se a imagem foi carregada corretamente
if img is None:
    print("Erro ao carregar a imagem. Verifique o nome e o caminho do arquivo.")
    exit()

# Define o kernel para a erosão
kernel = np.ones((5, 5), np.uint8)

# Aplica a operação de erosão
erosion = cv2.erode(img, kernel, iterations=1)

# Exibe a imagem resultante
cv2.imshow("Imagem", erosion)
cv2.waitKey(0)
cv2.destroyAllWindows()

