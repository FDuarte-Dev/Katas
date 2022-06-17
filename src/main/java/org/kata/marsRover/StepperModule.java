package org.kata.marsRover;

public class StepperModule {

    public void executeStep(LocationModule locationModule) {
        Direction direction = locationModule.getDirection();
        switch (direction) {
            case N -> stepNorth(locationModule);
            case W -> stepWest(locationModule);
            case S -> stepSouth(locationModule);
            case E -> stepEast(locationModule);
        }
    }

    public void stepNorth(LocationModule locationModule) {
        Coordinates coordinates = locationModule.getCoordinates();

        int Y = coordinates.getY();
        if (Y == Board.NORTH_LIMIT)
            Y = Board.SOUTH_LIMIT;
        else {
            Y++;
        }

        Coordinates newCoordinates = new Coordinates(coordinates.getX(), Y);
        locationModule.updateCoordinates(newCoordinates);
    }

    public void stepSouth(LocationModule locationModule) {
        Coordinates coordinates = locationModule.getCoordinates();

        int Y = coordinates.getY();
        if (Y == Board.SOUTH_LIMIT)
            Y = Board.NORTH_LIMIT;
        else {
            Y--;
        }

        Coordinates newCoordinates = new Coordinates(coordinates.getX(), Y);
        locationModule.updateCoordinates(newCoordinates);
    }

    public void stepEast(LocationModule locationModule) {
        Coordinates coordinates = locationModule.getCoordinates();

        int X = coordinates.getX();
        if (X == Board.EAST_LIMIT)
            X = Board.WEST_LIMIT;
        else {
            X++;
        }

        Coordinates newCoordinates = new Coordinates(X, coordinates.getY());
        locationModule.updateCoordinates(newCoordinates);
    }

    public void stepWest(LocationModule locationModule) {
        Coordinates coordinates = locationModule.getCoordinates();

        int X = coordinates.getX();
        if (X == Board.WEST_LIMIT)
            X = Board.EAST_LIMIT;
        else {
            X--;
        }

        Coordinates newCoordinates = new Coordinates(X, coordinates.getY());
        locationModule.updateCoordinates(newCoordinates);
    }
}
