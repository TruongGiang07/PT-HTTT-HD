package bankmgmt.API.Controllers;

import bankmgmt.BusinessLayer.KhachHangBUS;
import bankmgmt.POJO.KhachHang;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

/**
 * Created by TruongGiang on 5/7/2017.
 */

@RequestMapping("/api/kh")
@RestController
public class KhachHangController {

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<KhachHang> GetAll() {
        List<KhachHang> listKH = KhachHangBUS.getAll();
        return listKH;
    }

    @RequestMapping(value = "{makh}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public KhachHang GetKHById(@PathVariable int makh) {
        KhachHang kh = new KhachHang();

        return kh;
    }

    @RequestMapping(value = "add", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public ResponseEntity<KhachHang> Add(@RequestBody KhachHang kh) {
        if (kh != null && KhachHangBUS.add(kh)) {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.CREATED);
        } else {
            return new ResponseEntity<KhachHang>(kh, HttpStatus.NOT_MODIFIED);
        }
    }
}
