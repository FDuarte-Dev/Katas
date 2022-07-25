package org.kata.marsRover;

public class LocationModule {

    private Coordinates coordinates;
    private Direction direction;

    public LocationModule() {
        this.coordinates = new Coordinates();
        this.direction = Direction.N;
    }

    public void updateCoordinates(Coordinates newCoordinates) {
        this.coordinates = newCoordinates;
    }

    public void updateDirection(Direction newDirection) {
        this.direction = newDirection;
    }

    public String fullLocation() {
        return String.format("%d:%d:%s",
                coordinates.getX(),
                coordinates.getY(),
                direction);
    }

    public Direction getDirection() {
        return this.direction;
    }

    public Coordinates getCoordinates() {
        return this.coordinates;
    }
}
