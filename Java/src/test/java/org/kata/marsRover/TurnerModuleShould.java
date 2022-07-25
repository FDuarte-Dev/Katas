package org.kata.marsRover;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.junit.MockitoJUnitRunner;

import static org.mockito.ArgumentMatchers.any;
import static org.mockito.BDDMockito.given;
import static org.mockito.Mockito.verify;

@RunWith(MockitoJUnitRunner.class)
public class TurnerModuleShould {
    private TurnerModule turnerModule;
    @Mock
    LocationModule locationModule;

    @Before
    public void initialize() {
        this.turnerModule = new TurnerModule();
    }

    @Test(expected = IllegalStateException.class)
    public void not_turn_on_invalid_input() {
        turnerModule.executeTurn('A', locationModule);
    }

    @Test
    public void turn_left() {
        Direction direction = Direction.N;
        given(locationModule.getDirection()).willReturn(direction);

        turnerModule.executeTurn('L', locationModule);

        verify(locationModule).updateDirection(any(Direction.class));
    }

    @Test
    public void turn_right() {
        Direction direction = Direction.N;
        given(locationModule.getDirection()).willReturn(direction);

        turnerModule.executeTurn('R', locationModule);

        verify(locationModule).updateDirection(any(Direction.class));
    }


}
