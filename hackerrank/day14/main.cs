using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] a) {
        this.elements = a;
    }

    public void computeDifference() {
        int max = elements.Max();
        int min = elements.Min();

        maximumDifference = Math.Abs(max - min);
    }

} // End of Difference Class