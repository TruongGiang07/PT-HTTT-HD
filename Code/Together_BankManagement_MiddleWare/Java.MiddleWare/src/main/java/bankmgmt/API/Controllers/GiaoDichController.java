package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.GiaoDichBUS;
import bankmgmt.POJO.GiaoDich;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;


@RequestMapping("/api/giaodich")
@RestController
public class GiaoDichController {

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<GiaoDich> GetAll() {
        return GiaoDichBUS.getAll();
    }
}