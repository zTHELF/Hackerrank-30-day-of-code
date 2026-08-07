process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Reads complete line from STDIN (ahora es una promesa)
function readLine(prompt) {
    return new Promise((resolve) => {
        rl.question(prompt, (answer) => resolve(answer));
    });
}

async function main() {
    var i = 4
    var d = 4.0
    var s = "HackerRank "

    // Declare second integer, double, and String variables.
    var entero;
    var decimal;
    var texto;

    // Read and save an integer, double, and String to your variables.
    entero = parseInt(await readLine("Ingrese un número entero: "));

    decimal = parseFloat(await readLine("Ingrese un número decimal: "));

    texto = await readLine("Ingrese un texto: ");

    // Print the sum of both integer variables on a new line.
    console.log(`La suma de los numeros enteros: ${i + entero}`);

    // Print the sum of the double variables on a new line.
    console.log(`La suma de los numeros decimales: ${d + decimal}`);

    // Concatenate and print the String variables on a new line.
    console.log(`La concatenacion entre los textos es: ${s}${texto}`);

    rl.close();
}

main();