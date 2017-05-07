package bankmgmt.main;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@SpringBootApplication
@ComponentScan("bankmgmt.API.Controllers")
public class BankManagementMiddleWareApplication {

	public static void main(String[] args) {
		SpringApplication.run(BankManagementMiddleWareApplication.class, args);
	}
}
