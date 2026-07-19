# Enter your code here. Read input from STDIN. Print output to STDOUT
n = int(input().strip())

output = []

for _ in range(n):
    s = input()
    even = s[0::2]
    odd = s[1::2]
    output.append(even + " " + odd)

print("\n".join(output))