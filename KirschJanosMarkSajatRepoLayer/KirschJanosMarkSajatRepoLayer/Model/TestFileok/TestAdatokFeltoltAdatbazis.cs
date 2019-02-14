using KirschJanosMarkSajatRepoLayer.Adatbazis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirschJanosMarkSajatRepoLayer.Model.TestFileok
{
    class TestAdatokFeltoltAdatbazis
    {
        public TestAdatokFeltoltAdatbazis()
        {
            AdatbazisKezelo ak = new AdatbazisKezelo();
            ak.parancsAdatbazisVegrehajt("DROP TABLE accountok; CREATE TABLE `accountok` ( `az` int(11) NOT NULL," +
                "  `felhNev` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `jelszo` varchar(28) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `email_cim` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `jog` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL," +
                "  `szint` int(11) NOT NULL," +
                "  `regio_az` smallint(6) DEFAULT NULL" +
                ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;" +
                "INSERT INTO `accountok` (`az`, `felhNev`, `jelszo`, `email_cim`, `jog`, `szint`, `regio_az`) VALUES" +
                "(1, 'user', 'user', 'username@gmail.com', 'felhasználó', 1, 3)," +
                "(2, 'gycsaba', 'gycsaba', 'gyuris.csaba@vasvari.hu', 'felhasználó', 1, 3)," +
                "(3, 'baro', 'baro123', 'balint.robert@vasvari.hu', 'felhasználó', 1, 3); ");

            ak.bezaras();
        }
    }
}
