package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.ChiNhanhBUS;
import bankmgmt.POJO.ChiNhanh;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

/**
 * Created by TruongGiang on 5/18/2017.
 */

@RequestMapping("/api/chinhanh")
@RestController
public class ChiNhanhController {

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<ChiNhanh> GetAll() {
        return ChiNhanhBUS.getAll();
    }
}
