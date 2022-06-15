package org.kata.fizzBuzz;

public class FizzBuzz {

    public String convert(int number) {
        StringBuilder sb = new StringBuilder();
        if (isMultipleOfThree(number))
            sb.append("Fizz");
        if (isMultipleOfFive(number))
            sb.append("Buzz");
        return sb.length() > 0 ? sb.toString() : String.valueOf(number);
    }

    public boolean isMultipleOfThree(int number) {
        return number % 3 == 0;
    }

    public boolean isMultipleOfFive(int number) {
        return number % 5 == 0;
    }
}
