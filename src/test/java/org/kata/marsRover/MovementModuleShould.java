package org.kata.marsRover;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.junit.MockitoJUnitRunner;

import static org.mockito.Mockito.*;

@RunWith(MockitoJUnitRunner.class)
public class MovementModuleShould {

    private static final String STEPS = "MMRMMLM";
    private MovementModule movementModule;
    @Mock
    LocationModule locationModule;
    @Mock StepperModule stepperModule;
    @Mock TurnerModule turnerModule;

    @Before
    public void initialize() {
        this.movementModule = new MovementModule(locationModule, stepperModule,
                turnerModule);
    }

    @Test
    public void run_the_path() {
        movementModule.runPath(STEPS);

        verify(stepperModule, times(5)).executeStep(locationModule);
        verify(turnerModule).executeTurn('L', locationModule);
        verify(turnerModule).executeTurn('R', locationModule);
    }

    @Test
    public void step_forward() {
        movementModule.step();

        verify(stepperModule).executeStep(locationModule);
    }

    @Test
    public void turn_left() {
        char step = 'L';

        movementModule.turn(step);

        verify(turnerModule).executeTurn(step, locationModule);
    }

    @Test
    public void turn_right() {
        char step = 'R';

        movementModule.turn(step);

        verify(turnerModule).executeTurn(step, locationModule);
    }

    @Test
    public void get_location() {
        movementModule.getLocation();

        verify(locationModule).fullLocation();
    }
}
