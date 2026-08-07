#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    // Declare a variable named 'usuario' to hold our input.
    string usuario;

    // Show a prompt asking for a message.
    cout << "Ponga un mensaje: ";

    // Read a full line of input from stdin (cin) and save it to our variable, usuario.
    getline(cin, usuario);

    // Print a string literal saying "Hola, Mundo." to stdout using cout.
    cout << "Hola, Mundo." << endl;

    // Print the contents of usuario along with a custom label.
    cout << "Mensaje dirigido del usuario: " << usuario << endl;

    return 0;
}