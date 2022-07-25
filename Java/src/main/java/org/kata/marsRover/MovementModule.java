package org.kata.marsRover;

public class MovementModule {

    private final LocationModule locationModule;
    private final StepperModule stepperModule;
    private final TurnerModule turnerModule;

    public MovementModule(
            LocationModule locationModule,
            StepperModule stepperModule,
            TurnerModule turnerModule) {
        this.locationModule = locationModule;
        this.stepperModule = stepperModule;
        this.turnerModule = turnerModule;
    }

    public void runPath(String steps) {
        for (char step: steps.toCharArray()) {
            if (step == 'M')
                step();
            else {
                turn(step);
            }
        }
    }

    protected void step() {
        stepperModule.executeStep(locationModule);
    }

    protected void turn(char step) {
        turnerModule.executeTurn(step, locationModule);
    }

    public String getLocation() {
        return locationModule.fullLocation();
    }
}
