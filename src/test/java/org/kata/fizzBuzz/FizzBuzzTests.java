package org.kata.fizzBuzz;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class FizzBuzzTests {

    @Test
    public void return_number() {
        Assertions.assertEquals("1", new FizzBuzz().convert(1));
    }

    @Test
    public void return_fizz() {
        Assertions.assertEquals("Fizz", new FizzBuzz().convert(3));
    }

    @Test
    public void return_buzz() {
        Assertions.assertEquals("Buzz", new FizzBuzz().convert(5));
    }

    @Test
    public void return_fizz_buzz() {
        Assertions.assertEquals("FizzBuzz", new FizzBuzz().convert(15));
    }
}
