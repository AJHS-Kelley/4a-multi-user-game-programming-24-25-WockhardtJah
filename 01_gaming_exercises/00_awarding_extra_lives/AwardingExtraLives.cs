using System;
class Template {
  static void Main() {
<<<<<<< HEAD
    
  }
}
# Start with 3 lives
=======
 # Start with 3 lives
>>>>>>> bca88a332b0dc7d27cd0ff48f9f0c8b9d20a5b5a
lives = 3

# Get the player's score as input
score = int(input("Enter the player's score: "))

# Determine the number of lives based on the score
if score < 10000:
    lives -= 1  # Lose 1 life
elif 10001 <= score < 100000:
    lives += 1  # Gain 1 extra life

# Output the final number of lives
print("The player now has {lives} lives.")   
  }
}