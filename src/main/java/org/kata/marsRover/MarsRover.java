package org.kata.marsRover;

public class MarsRover {

    public MovementModule movementModule;

    public MarsRover(MovementModule movementModule) {
        this.movementModule = movementModule;
    }

    public String execute() {
        return execute("");
    }

    public String execute(String steps) {
        movementModule.runPath(steps);
        return movementModule.getLocation();
    }
}
