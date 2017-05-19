package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.TruSoBUS;
import bankmgmt.POJO.TruSo;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

/**
 * Created by TruongGiang on 5/18/2017.
 */

@RequestMapping("/api/truso")
@RestController
public class TruSoController {

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<TruSo> GetAll() {
        return TruSoBUS.getAll();
    }
}
