if __name__ == '__main__':
    n = int(input())

    phone_book = {}

    for _ in range(n):
        entry = input().split()
        name = entry[0]
        number = entry[1]
        phone_book[name] = number

    while True:
        try:
            query = input()
        except EOFError:
            break

        if query in phone_book:
            print(f"{query}={phone_book[query]}")
        else:
            print("Not found")