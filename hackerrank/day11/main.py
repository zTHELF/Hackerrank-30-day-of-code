if __name__ == '__main__':

    arr = []

    for _ in range(6):
        arr.append(list(map(int, input().rstrip().split())))

    max_suma = None

    for fila in range(4):       # solo puede empezar hasta la fila 3 (índice 0-3)
        for col in range(4):    # solo puede empezar hasta la columna 3 (índice 0-3)
            suma = (
                arr[fila][col] + arr[fila][col + 1] + arr[fila][col + 2] +
                arr[fila + 1][col + 1] +
                arr[fila + 2][col] + arr[fila + 2][col + 1] + arr[fila + 2][col + 2]
            )

            if max_suma is None or suma > max_suma:
                max_suma = suma

    print(max_suma)