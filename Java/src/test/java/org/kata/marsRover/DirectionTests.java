package org.kata.marsRover;

import org.junit.Test;
import org.junit.jupiter.api.Assertions;

public class DirectionTests {
    @Test
    public void norths_left_is_west() {
        Direction north = Direction.N;
        Direction west = Direction.W;

        Assertions.assertEquals(west, north.left());
    }

    @Test
    public void wests_left_is_south() {
        Direction west = Direction.W;
        Direction south = Direction.S;

        Assertions.assertEquals(south, west.left());
    }

    @Test
    public void souths_left_is_east() {
        Direction south = Direction.S;
        Direction east = Direction.E;

        Assertions.assertEquals(east, south.left());
    }

    @Test
    public void easts_left_is_north() {
        Direction east = Direction.E;
        Direction north = Direction.N;

        Assertions.assertEquals(north, east.left());
    }

    @Test
    public void norths_right_is_east() {
        Direction north = Direction.N;
        Direction east = Direction.E;

        Assertions.assertEquals(east, north.right());
    }

    @Test
    public void easts_right_is_south() {
        Direction east = Direction.E;
        Direction south = Direction.S;

        Assertions.assertEquals(south, east.right());
    }

    @Test
    public void souths_right_is_west() {
        Direction south = Direction.S;
        Direction west = Direction.W;

        Assertions.assertEquals(west, south.right());
    }

    @Test
    public void wests_left_is_north() {
        Direction west = Direction.W;
        Direction north = Direction.N;

        Assertions.assertEquals(north, west.right());
    }
}
