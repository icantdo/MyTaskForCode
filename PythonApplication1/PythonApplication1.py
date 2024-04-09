import random

def play_hangman():
    words = ["apple", "banana", "orange", "grape", "melon"]
    secret_word_int = random.randint(1-5)
    secret_word = words[secret_word_int];    
    guessed_letters = []
    attempts = 6

    print("Welcome to Hangman!")
    print("The secret word has", len(secret_word), "letters.")

    while attempts > 0:
        hidden_word = ""
        for letter in secret_word:
            if letter in guessed_letters:
                hidden_word += letter
            else:
                hidden_word += "_"

        print("Word:", hidden_word)
        print("Attempts left:", attempts)

        guess = input("Guess a letter: ").lower()

        if guess in guessed_letters:
            print("You already guessed that letter.")
        elif guess in secret_word:
            guessed_letters.append(guess)
            print("Correct guess!")
        else:
            print("Incorrect guess.")
            attempts -= 1

        if "_" not in hidden_word:
            print("Congratulations! You guessed the word:", secret_word)
            break

    if attempts == 0:
        print("You ran out of attempts. The word was:", secret_word)

play_hangman()
