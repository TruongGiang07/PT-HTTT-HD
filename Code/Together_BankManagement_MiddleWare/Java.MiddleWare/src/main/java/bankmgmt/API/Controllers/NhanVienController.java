package bankmgmt.API.Controllers;


import bankmgmt.BusinessLayer.NhanVienBUS;
import bankmgmt.POJO.NhanVien;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.http.HttpStatus;
import java.util.List;

/**
 * Created by KhoaPham on 24/05/2017.
 */

@RequestMapping("/api/nv")
@RestController
public class NhanVienController {

    @RequestMapping(value = "all", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<NhanVien> GetAll() {
        List<NhanVien> listNV = NhanVienBUS.getAll();
        return listNV;
    }
    @RequestMapping(value = "id/{manv}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<NhanVien> GetNVById(@PathVariable int manv) {
        List<NhanVien> listNV = NhanVienBUS.getNVByID(manv);
        return listNV;
    }

    @RequestMapping(value = "hoten/{hoten}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public List<NhanVien> GetNVByHoTen(@PathVariable String hoten) {
        List<NhanVien> listNV = NhanVienBUS.getNVByHoTen(hoten);
        return listNV;
    }
    /*
    @RequestMapping(value = "{makh}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public KhachHang GetKHById(@PathVariable int makh) {
        KhachHang kh = new KhachHang();

        return kh;
    }
*/
    @RequestMapping(value = "add", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public ResponseEntity<NhanVien> AddNV(@RequestBody NhanVien nv) {
        if (nv != null && NhanVienBUS.add(nv)) {
            return new ResponseEntity<NhanVien>(nv, HttpStatus.CREATED);
        } else {
            return new ResponseEntity<NhanVien>(nv, HttpStatus.NOT_MODIFIED);
        }
    }

    @RequestMapping(value = "up", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public ResponseEntity<NhanVien> UpNV(@RequestBody NhanVien nv) {
        if (nv != null && NhanVienBUS.up(nv)) {
            return new ResponseEntity<NhanVien>(nv, HttpStatus.CREATED);
        } else {
            return new ResponseEntity<NhanVien>(nv, HttpStatus.NOT_MODIFIED);
        }
    }

    @RequestMapping(value = "del", method = RequestMethod.POST, produces = {MediaType.APPLICATION_JSON_VALUE})
    public ResponseEntity<NhanVien> DelNV(@RequestBody NhanVien nv) {
        if (nv != null && NhanVienBUS.del(nv)) {
            return new ResponseEntity<NhanVien>(nv, HttpStatus.CREATED);
        } else {
            return new ResponseEntity<NhanVien>(nv, HttpStatus.NOT_MODIFIED);
        }
    }

}
