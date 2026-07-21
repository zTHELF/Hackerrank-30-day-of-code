#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input().strip())

    binario = bin(n)[2:]  # bin(n) devuelve algo como '0b101', quitamos el '0b'

    contador_actual = 0
    contador_maximo = 0

    for bit in binario:
        if bit == '1':
            contador_actual += 1
            contador_maximo = max(contador_maximo, contador_actual)
        else:
            contador_actual = 0

    print(contador_maximo)
