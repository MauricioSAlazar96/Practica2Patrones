package facade.main;

import facade.facade.DeviceFacade;

public class ClientFacade {

	public static void main(String[] args) {
		DeviceFacade facade = new DeviceFacade();
		facade.turnOnAll();		
		facade.turnOffAll();
	}

}
