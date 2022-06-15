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
        if (Y == 9)
            Y = 0;
        else {
            Y++;
        }

        Coordinates newCoordinates = new Coordinates(coordinates.getX(), Y);
        locationModule.updateCoordinates(newCoordinates);
    }

    public void stepSouth(LocationModule locationModule) {
        Coordinates coordinates = locationModule.getCoordinates();

        int Y = coordinates.getY();
        if (Y == 0)
            Y = 9;
        else {
            Y--;
        }

        Coordinates newCoordinates = new Coordinates(coordinates.getX(), Y);
        locationModule.updateCoordinates(newCoordinates);
    }

    public void stepEast(LocationModule locationModule) {
        Coordinates coordinates = locationModule.getCoordinates();

        int X = coordinates.getX();
        if (X == 9)
            X = 0;
        else {
            X++;
        }

        Coordinates newCoordinates = new Coordinates(X, coordinates.getY());
        locationModule.updateCoordinates(newCoordinates);
    }

    public void stepWest(LocationModule locationModule) {
        Coordinates coordinates = locationModule.getCoordinates();

        int X = coordinates.getX();
        if (X == 0)
            X = 9;
        else {
            X--;
        }

        Coordinates newCoordinates = new Coordinates(X, coordinates.getY());
        locationModule.updateCoordinates(newCoordinates);
    }
}
