if __name__ == '__main__':
    N = input('Digite un numero entero o decimal: ').strip()

    if (N.replace('.', '', 1).isdigit()):
        N = (float(N) if '.' in N else int(N))

        if (N % 2 != 0):
            print("Weird")
        elif (N % 2 == 0 and 2 <= N <= 5):
            print("Not Weird")
        elif (N % 2 == 0 and 6 <= N <= 20):
            print("Weird")
        elif (N % 2 == 0 and N > 20):
            print("Not Weird")
    else:
        print('Digitaste un texto, por favor digita un numero entero o decimal.')
