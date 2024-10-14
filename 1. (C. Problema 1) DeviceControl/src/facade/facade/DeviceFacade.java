package facade.facade;

import facade.device.impl.Light;
import facade.device.impl.Lock;
import facade.device.impl.Thermostat;

public class DeviceFacade {

	private Light light;
	private Lock lock;
	private Thermostat thermostat;
	
	public DeviceFacade() {
		light = new Light();
		lock = new Lock();
		thermostat = new Thermostat();
	}
	
	public void turnOnAll() {
		System.out.println("TURN ON ALL DEVICES");
		light.turnOn();
		lock.turnOn();
		thermostat.turnOn();
	}
	
	public void turnOffAll() {
		System.out.println("TURN OFF ALL DEVICES");
		light.turnOff();
		lock.turnOff();
		thermostat.turnOff();
	}
}