function processData(input) {
    const lines = input.split("\n");
    const n = parseInt(lines[0]);
    
    let output = [];
    
    for (let i = 1; i <= n; i++) {
        const str = lines[i].trim();
        let even = "";
        let odd = "";
        
        for (let j = 0; j < str.length; j++) {
            if (j % 2 === 0) {
                even += str[j];
            } else {
                odd += str[j];
            }
        }
        
        output.push(even + " " + odd);
    }
    
    console.log(output.join("\n"));
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
