package facade.device.impl;

import facade.device.Device;

public class Light extends Device {

	public Light() {
		super("light");		
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
