package facade.device.impl;

import facade.device.Device;

public class Thermostat extends Device {

	public Thermostat() {
		super("thermostat");
	}

	@Override
	public void turnOn() {
		System.out.println("Turning On "+this.getDevice());
	}

	@Override
	public void turnOff() {
		System.out.println("Turning Off "+this.getDevice());
	}

}
