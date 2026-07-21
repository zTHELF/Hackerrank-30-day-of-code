function processData(input) {
    //Enter your code here
    const lines = input.split('\n');
    let currentLine = 0;

    const n = parseInt(lines[currentLine++].trim(), 10);

    const phoneBook = {};

    for (let i = 0; i < n; i++) {
        const entry = lines[currentLine++].split(' ');
        const name = entry[0];
        const number = entry[1];
        phoneBook[name] = number;
    }

    const output = [];
    while (currentLine < lines.length) {
        const query = lines[currentLine++].trim();
        if (query === '') {
            continue;
        }

        if (phoneBook.hasOwnProperty(query)) {
            output.push(`${query}=${phoneBook[query]}`);
        } else {
            output.push("Not found");
        }
    }

    console.log(output.join('\n'));
}

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});