const readline = require('readline');
const rl = readline.createInterface({ input: process.stdin, output: process.stdout });

function processData(inputString) {
    console.log("Hello, World.");
    console.log(`Mensaje dirigido de la persona: ${inputString}`);
}

rl.question("Digite un mensaje: ", (inputString) => {
    processData(inputString);
    rl.close();
});