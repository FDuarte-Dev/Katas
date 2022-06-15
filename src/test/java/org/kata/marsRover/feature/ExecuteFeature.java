package org.kata.marsRover.feature;

import org.junit.Before;
import org.junit.Test;
import org.kata.marsRover.*;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ExecuteFeature {

    static String INITIAL_POSITION = "0:0:N";
    private MarsRover rover;

    @Before
    public void initialize() {
        LocationModule locationModule = new LocationModule();
        StepperModule stepperModule = new StepperModule();
        TurnerModule turnerModule = new TurnerModule();
        MovementModule movementModule = new MovementModule(locationModule, stepperModule, turnerModule);
        rover = new MarsRover(movementModule);
    }

    @Test
    public void initial_position() {

        String position = rover.execute();

        assertEquals(INITIAL_POSITION, position);
    }

    @Test
    public void move_rover() {

        String STEPS = "MMRMMLM";
        String FINAL_POSITION = "2:3:N";

        String position = rover.execute(STEPS);

        assertEquals(FINAL_POSITION, position);
    }

    @Test
    public void wrap_around() {

        String STEPS = "MMMMMMMMMM";

        String position = rover.execute(STEPS);

        assertEquals(INITIAL_POSITION, position);
    }
}
