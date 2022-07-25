package org.kata.marsRover;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.junit.MockitoJUnitRunner;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.mockito.Mockito.verify;


@RunWith(MockitoJUnitRunner.class)
public class MarsRoverShould {

    private MarsRover rover;
    @Mock
    MovementModule movementModule;

    @Before
    public void initialize() {
        rover = new MarsRover(movementModule);
    }

    @Test
    public void ignore_no_movement() {
        rover.execute();

        verify(movementModule).runPath("");
    }

    @Test
    public void run_movement_module() {
        rover.execute("MMRMMLM");
        
        verify(movementModule).runPath("MMRMMLM");
    }
}