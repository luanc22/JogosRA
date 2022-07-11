text = input("insira o texto: \n")
total = len(text)

for ind in range(total):
    msg = ''
    count = 0
    last_letter = ''

    for letter in text:
        msg += letter
        count += 1
        if count > ind:
            last_letter = letter
            break

    if last_letter != ' ':
        print(msg)

print()

for ind in range(total):
    msg = ''
    count = total
    count -= ind
    last_letter = ''

    for letter in text:
        msg += letter
        count -= 1
        if count == 0:
            last_letter = letter
            break

    if last_letter != ' ':
        print(msg)