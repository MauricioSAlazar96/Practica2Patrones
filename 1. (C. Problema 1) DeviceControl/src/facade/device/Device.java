package facade.device;

public abstract class Device {

	private String device;
	
	public Device(String device) {
		this.device = device;
	}
	
	public abstract void turnOn();
	
	public abstract void turnOff();
	
	protected String getDevice() {
		return device;
	}
}
