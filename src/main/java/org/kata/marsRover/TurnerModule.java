package org.kata.marsRover;

public class TurnerModule {
    public void executeTurn(char step, LocationModule locationModule) {
        switch (step) {
            case 'L' -> turnLeft(locationModule);
            case 'R' -> turnRight(locationModule);
            default -> throw new IllegalStateException("Unexpected value: " + step);
        }
    }

    private void turnLeft(LocationModule locationModule) {
        Direction direction = locationModule.getDirection();
        Direction newDirection = direction.left();
        locationModule.updateDirection(newDirection);
    }

    private void turnRight(LocationModule locationModule) {
        Direction direction = locationModule.getDirection();
        Direction newDirection = direction.right();
        locationModule.updateDirection(newDirection);
    }
}
