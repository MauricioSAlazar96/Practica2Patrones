package facade.device.impl;

import facade.device.Device;

public class Lock extends Device  {

	public Lock() {
		super("lock");
	}

	@Override
	public void turnOn() {
		System.out.println("Opening "+this.getDevice());
	}

	@Override
	public void turnOff() {
		System.out.println("Closing "+this.getDevice());		
	}

}
