package org.kata.marsRover;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

public class LocationModuleShould {

    private static final String INITIAL_LOCATION = "0:0:N";
    private LocationModule locationModule;

    @BeforeEach
    public void initialize() {
        locationModule = new LocationModule();
    }

    @Test
    public void update_coordinates() {
        Coordinates newCoordinates = new Coordinates(1, 0);

        locationModule.updateCoordinates(newCoordinates);

        Assertions.assertNotEquals(INITIAL_LOCATION, locationModule.fullLocation());
    }

    @Test
    public void update_direction() {
        Direction newDirection = Direction.S;

        locationModule.updateDirection(newDirection);

        Assertions.assertNotEquals(INITIAL_LOCATION, locationModule.fullLocation());
    }

    @Test
    public void print_full_location() {
        String location = locationModule.fullLocation();

        Assertions.assertEquals(INITIAL_LOCATION, location);
    }
}
