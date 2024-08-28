def average():
    numbers = []
    while True:
        number = int(input("Enter a number: "))
        numbers.append(number)
        user_input = input("Do you want to enter another number? Yes/No: ")
        if user_input.lower() == 'no':
            break
    avg = sum(numbers) / len(numbers)
    print(f"Average is: {avg}")
    
    if avg >= 10:
        print(f"Double Digits")
    else:
        print(f"Single Digits")

average()
