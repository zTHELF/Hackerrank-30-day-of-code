'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function main() {

    let arr = Array(6);

    for (let i = 0; i < 6; i++) {
        arr[i] = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));
    }

    let maxSuma = -Infinity;

    for (let fila = 0; fila < 4; fila++) {
        for (let col = 0; col < 4; col++) {
            const suma =
                arr[fila][col] + arr[fila][col + 1] + arr[fila][col + 2] +
                arr[fila + 1][col + 1] +
                arr[fila + 2][col] + arr[fila + 2][col + 1] + arr[fila + 2][col + 2];

            if (suma > maxSuma) {
                maxSuma = suma;
            }
        }
    }

    console.log(maxSuma);
}