package org.kata.marsRover;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.junit.MockitoJUnitRunner;

import static org.mockito.BDDMockito.given;
import static org.mockito.Mockito.verify;

@RunWith(MockitoJUnitRunner.class)
public class StepperModuleShould {

    @Mock LocationModule locationModule;
    @Mock Coordinates coordinates;
    private StepperModule stepperModule;

    @Before
    public void initialize() {
        this.stepperModule = new StepperModule();
    }

    @Test
    public void execute_step_north() {
        Coordinates coordinates = new Coordinates();
        Coordinates newCoordinates = new Coordinates(0, 1);
        given(locationModule.getDirection()).willReturn(Direction.N);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.executeStep(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);
    }

    @Test
    public void execute_step_south() {
        Coordinates coordinates = new Coordinates();
        Coordinates newCoordinates = new Coordinates(0, 9);
        given(locationModule.getDirection()).willReturn(Direction.S);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.executeStep(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);
    }

    @Test
    public void execute_step_east() {
        Coordinates coordinates = new Coordinates();
        Coordinates newCoordinates = new Coordinates(1, 0);
        given(locationModule.getDirection()).willReturn(Direction.E);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.executeStep(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);    }

    @Test
    public void execute_step_west() {
        Coordinates coordinates = new Coordinates();
        Coordinates newCoordinates = new Coordinates(9, 0);
        given(locationModule.getDirection()).willReturn(Direction.W);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.executeStep(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);    }

    @Test
    public void step_north() {
        Coordinates coordinates = new Coordinates(0, 0);
        Direction direction = Direction.N;
        Coordinates newCoordinates = new Coordinates(0, 1);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.stepNorth(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);
    }

    @Test
    public void step_south() {
        Coordinates coordinates = new Coordinates(0, 0);
        Direction direction = Direction.S;
        Coordinates newCoordinates = new Coordinates(0, 9);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.stepSouth(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);
    }

    @Test
    public void step_east() {
        Coordinates coordinates = new Coordinates(0, 0);
        Direction direction = Direction.E;
        Coordinates newCoordinates = new Coordinates(1, 0);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.stepEast(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);
    }

    @Test
    public void step_west() {
        Coordinates coordinates = new Coordinates(0, 0);
        Direction direction = Direction.W;
        Coordinates newCoordinates = new Coordinates(9, 0);
        given(locationModule.getCoordinates()).willReturn(coordinates);

        stepperModule.stepWest(locationModule);

        verify(locationModule).updateCoordinates(newCoordinates);
    }
}
