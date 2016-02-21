﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Resources;
using System.Windows.Media.Animation;



namespace ElTrompo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] turno = { "Vespertino", "Matutino", "Diurno" };

        string[] sector = { "Publica", "Privada" };

        string[] estados = {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Coahuila", "Colima",
                                "Chiapas", "Ciudad de Mexico", "Chihuahua", "Durango", "Guanajuato", "Guerrero", "Hidalgo",
                                "Jalisco", "Mexico", "Michoacan", "Morelos", "Nayarit", "Nuevo Leon", "Oaxaca", "Puebla", "Queretaro",
                                "Quintana Roo", "San Luis Potosi", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala",
                                "Veracruz", "Yucatan", "Zacatecas"};

        string[] AguascalientesMun = {"Aguascalientes", "Asientos", "Calvillo", "Cosio", "El llano", "Jesus Maria",
                                "Pabellon de Arteaga", "Rincon de Romos", "San Francisco de los Romos", "San Jose de Gracia",
                                "Tepezala"};

        string[] BajaCaliforniaMun = { "Ensenada", "Mexicali", "Rosarito", "Tecate", "Tijuana" };

        string[] BajaCaliforniaSMun = { "Comondu", "La Paz", "Loreto", "Los Cabos", "Mulege" };

        string[] CampecheMun = {"Acacoyagua","Acala","Acapetahua","Aldama","Altamirano","Amatan","Amatenango de la Frontera",
                                "Amatenango del Valle","Angel Albino Corzo","Arriaga","Bejucal de Ocampo","Bella Vista",
                                "Benemerito de las Americas","Berriozabal","Bochil","Cacahoatan","Chalchihuitan","Chamula","Chanal",
                                "Chapultenango","Catazaja","Chenalho","Chiapa de Corzo","Chiapilla","Chicoasen","Chicomosuelo","Cintalpa",
                                "Chilon","Coapilla","Comitan de Dominguez","Copainala","El Bosque","El Porvenir","Escuintla","Francisco Leon",
                                "Frontera Comalapa","Frontera Hidalgo","Huehuetan","Huitiupan","Huixtan","Huixtla","Ixhuatan","Ixtacomitan",
                                "Ixtapa","Ixtapangajoya","Jiquipilas","Jitotol","Juarez","La Concordia","La Grandeza","La Independencia",
                                "La Libertad","La Trinitaria","Larrainzar","Las Margaritas","Las Rosas","Mapastepec","Maravilla Tenejapa",
                                "Marques de Comillas","Mazapa de Madero","Mazatan","Metapa","Mitontic","Montecristo de Guerrero","Motozintla",
                                "Nicolas Ruiz","Ocosingo","Ocotepec","Ocozocoautla de Espinosa","Ostuacan","Osumacinta","Oxchuc","Palenque","Pantelho",
                                "Pantepec","Pichucalco","Pijijiapan","Pueblo Nuevo Solistahuacan","Rayon","Reforma","Sabanilla","Salto de Agua",
                                "San Andres Duraznal","San Cristobal de las Casas","San Fernando","San Juan Cancuc","San Lucas","Santiago el Pinar",
                                "Siltepec","Simojovel","Sitala","Socoltenango","Solosuchiapa","Soyalo","Suchiapa","Suchiate","Sunuapa","Tapachula",
                                "Tapalapa","Tapilula","Tecpatan","Tenejapa","Teopisca","Tila","Tonala","Totolapa","Tumbala","Tuxtla Chico","Tuxtla Gutierrez",
                                "Tuzantan","Tzimol","Union Juarez","Venustiano Carranza","Villa Comaltitlan","Villa Corzo","Villaflores","Yajalon","Zinacantan"};

        string[] CoahuilaMun = {"Abasolo","Acuña","Allende","Arteaga","Candela","Castaños","Cuatrocienegas","Escobedo","Francisco I. Madero","Frontera",
                                "General Cepeda","Guerrero","Hidalgo","Jimenez","Juarez","Lamadrid","Matamoros","Monclova","Morelos","Muzquiz","Nadadores",
                                "Nava","Ocampo","Parras","Piedras Negras","Progreso","Ramos Arizpe","Sabinas","Sacramento","Saltillo","San Buenaventura",
                                "San Juan de Sabinas","San Pedro","Sierra Mojada","Torreon","Viesca","Villa Union","Zaragoza"};

        string[] ColimaMun = {"Armeria","Colima","Comala","Coquimatlan","Cuauhtemoc","Ixtlahuacan","Manzanillo","Minatitlan","Tecoman","Villa de Alvarez"};

        string[] ChiapasMun = {"Acacoyagua","Acala","Acapetahua","Aldama","Altamirano","Amatan","Amatenango de la Frontera","Amatenango del Valle",
                               "Angel Albino Corzo","Arriaga","Bejucal de Ocampo","Bella Vista","Benemerito de las Americas","Berriozabal","Bochil",
                               "Cacahoatan","Chalchihuitan","Chamula","Chanal","Chapultenango","Catazaja","Chenalho","Chiapa de Corzo","Chiapilla",
                               "Chicoasen","Chicomosuelo","Cintalpa","Chilon","Coapilla","Comitan de Dominguez","Copainala","El Bosque","El Porvenir",
                               "Escuintla","Francisco Leon","Frontera Comalapa","Frontera Hidalgo","Huehuetan","Huitiupan","Huixtan","Huixtla","Ixhuatan",
                               "Ixtacomitan","Ixtapa","Ixtapangajoya","Jiquipilas","Jitotol","Juarez","La Concordia","La Grandeza","La Independencia",
                               "La Libertad","La Trinitaria","Larrainzar","Las Margaritas","Las Rosas","Mapastepec","Maravilla Tenejapa","Marques de Comillas",
                               "Mazapa de Madero","Mazatan","Metapa","Mitontic","Montecristo de Guerrero","Motozintla","Nicolas Ruiz","Ocosingo","Ocotepec",
                               "Ocozocoautla de Espinosa","Ostuacan","Osumacinta","Oxchuc","Palenque","Pantelho","Pantepec","Pichucalco","Pijijiapan",
                               "Pueblo Nuevo Solistahuacan","Rayon","Reforma","Sabanilla","Salto de Agua","San Andres Duraznal","San Cristobal de las Casas",
                               "San Fernando","San Juan Cancuc","San Lucas","Santiago el Pinar","Siltepec","Simojovel","Sitala","Socoltenango","Solosuchiapa",
                               "Soyalo","Suchiapa","Suchiate","Sunuapa","Tapachula","Tapalapa","Tapilula","Tecpatan","Tenejapa","Teopisca","Tila","Tonala",
                               "Totolapa","Tumbala","Tuxtla Chico","Tuxtla Gutierrez","Tuzantan","Tzimol","Union Juarez","Venustiano Carranza","Villa Comaltitlan",
                               "Villa Corzo","Villaflores","Yajalon","Zinacantan"};

        string[] CiudadDeMexicoMun = {"Alvaro Obregon","Azcapotzalco","Benito Juarez","Coyoacan","Cuajimalpa de Morelos","Cuauhtemoc","Gustavo A. Madero","Iztacalco",
                                      "Iztapalapa","Magdalena Contreras","Miguel Hidalgo","Milpa Alta","Tlahuac","Tlalpan","Venustiano Carranza","Xochimilco"};

        string[] ChihuahuaMun = {"Ahumada","Aldama","Allende","Aquiles Serdan","Ascension","Bachiniva","Balleza","Batopilas","Bocoyna","Buenaventura","Camargo",
                                 "Carichi","Casas Grandes","Chihuahua","Chinipas","Coronado","Coyame del Sotol","Cuauhtemoc","Cusihuiriachi","Delicias",
                                 "Dr. Belisario Dominguez","El Tule","Galeana","Gomez Farias","Gran Morelos","Guachochi","Guadalupe D.B.","Guadalupe y Calvo",
                                 "Guazapares","Guerrero","Hidalgo del Parral","Huejoitan","Ignacio Zaragoza","Janos","Jimenez","Juarez","Julimes","La Cruz",
                                 "Uriachi","Valle de Zaragoza"};

        string[] DurangoMun = {"Canatlan","Canelas","Coneto de Comonfort","Cuencame","Durango","El Oro","Gomez Palacio","Gral. Simon Bolivar","Guadalupe Victoria",
                                "Guanacevi","Hidalgo","Inde","Lerdo","Mapimi","Mezquital","Nazas","Nombre de Dios","Nuevo Ideal","Ocampo","Otaez","Panuco de Coronado",
                                "Peñon Blanco","Poanas","Pueblo Nuevo","Rodeo","San Bernardo","San Dimas","San Juan de Guadalupe","San Juan del Rio",
                                "San Luis del Cordero","San Pedro del Gallo","Santa Clara","Santiago Papasquiaro","Suchil","Tamazula","Tepehuanes","Tlahualilo",
                                "Topia","Vicente Guerrero"};

        string[] GuanajuatoMun = {"Abasolo","Acambaro","Apaseo el Alto","Apaseo el Grande","Atarjea","Celaya","Comonfort","Coroneo","Cortazar","Cueramaro","Doctor Mora",
                                  "Dolores Hidalgo","Guanajuato","Huanimaro","Irapuato","Jaral del Progreso","Jerecuaro","Leon","Manuel Doblado","Moroleon","Ocampo",
                                  "Penjamo","Pueblo Nuevo","Purisima del Rincon","Romita","Salamanca","Salvatierra","San Diego de la Union","San Felipe",
                                  "San Francisco del Rincon","San Jose Iturbide","San Luis de la Paz","San Miguel de Allende","Santa Catarina","Santa Cruz de Juventino",
                                  "Santiago Maravatio","Silao","Tarandacuao","Tarimoro","Tierra Blanca","Uruangato","Valle de Santiago","Victoria","Villagran",
                                  "Xichu","Yuriria"};

        string[] GuerreroMun = {"Acapulco de Juarez","Acatepec","Ahuacuotzingo","Ajuchitlan del Progreso","Alcozauca de Guerrero","Alpoyeca","Apaxtla de Castrejon",
                                "Arcelia","Atenango del Rio","Atlamajalcingo del Monte","Atlixtac","Atoyac de Alvarez","Ayutla de los Libres","Azoyu","Benito Juarez",
                                "Buenavista de Cuellar","Chilapa de Alvarez","Chilpancingo de los Bravo","Coahuayutla de Jose Maria Izazaga","Cochoapa el Grande",
                                "Cocula","Copala","Copalillo","Copanatoyac","Coyuca de Benitez","Coyuca de Catalan","Cuajinicuilapa","Cualac","Cuautepec",
                                "Cuetzala del Progreso","Cutzamala de Pinzon","Eduardo Neri","Florencio Villarreal","General Canuto A. Neri","General Heliodoro Castillo",
                                "Huamuxtitlan","Huitzuco de los Figueroa","Iguala de la Independencia","Igualapa","Iliatenco","Ixcateopan de Cuauhtemoc",
                                "Jose Joaquin de Herrera","Juan R. Escudero","Juchitan","La Union de Isidoro Montes de Oca","Leonardo Bravo","Malinaltepec","Marquelia",
                                "Martir de Cuilapan","Metlatonoc","Mochitlan","Olinala","Ometepec","Pedro Ascencio Alquisiras","Petatlan","Pilcaya","Pungarabato",
                                "Quechultenango","San Luis Acatlan","San Marcos","San Miguel Totolapan","Taxco de Alarcon","Tecoanapa","Tecpan de Galeana","Teloloapan",
                                "Tepecoacuilco de Trujano","Tetipac","Tixtla de Guerrero","Tlacoachistlahuaca","Tlacoapa","Tlalchapa","Tlalixtlaquilla de Maldanado",
                                "Tlapa de Comonfort","Tlapehuala","Xalpatlahuac","Xochihuehuetlan","Xochistlahuaca","Zapotitlan Tablas","Zihuatanejo de Azueta",
                                "Zirandaro de los Chavez","Zitlala"};

        string[] HidalgoMun = {"Acatlan","Acaxochitlan","Actopan","Agua Blanca de Iturbide","Ajacuba","Alfajayucan","Almoloya","Apan","Atitalaquia","Atlapexco",
                                "Atotonilco de Tula","Atotonilco el Grande","Calnali","Chapantongo","Chapulhuacan","Cardonal","Chilcuautla","Cuautepec de Hinojosa",
                                "El Arenal","Eloxochitlan","Emiliano Zapata","Epazoyucan","Francisco I. Madero","Huasca de Ocampo","Huautla","Huazalingo",
                                "Huejutla de Reyes","Huehuetla  ","Huichapan","Ixmiquilpan","Jacala de Ledezma","Jaltocan","Juarez Hidalgo","La Mision","Lolotla",
                                "Metepec","Metztitlan","Mineral de la Reforma","Mineral del Chico","Mineral del Monte","Mixquiahuala de Juarez","Molango de Escamilla",
                                "Nicolas Flores","Nopala de Villagran","Omitlan de Juarez","Pachuca de Soto","Pacula","Pisaflores","Progreso de Obregon",
                                "San Agustin Metzquititlan","San Agustin Tlaxiaca","San Bartolo Tutotepec","San Felipe Orizatlan","San Salvador","Santiago de Anaya",
                                "Santiago Tulantepec de Lugo Guerrero","Singuilucan","Tasquillo","Tecozautla","Tenango de Doria","Tepeapulco","Tepehuacan de Guerrero",
                                "Tepeji del Rio de Ocampo","Tepetitlan","Tetepango","Tezontepec de Aldama","Tianguistengo","Tizayuca","Tlahuelilpan","Tlahuiltepa",
                                "Tlanalapa","Tlanchinol","Tlaxcoapan","Tolcayuca","Tula de Allende","Tulancingo de Bravo","Villa de Tezontepec","Xochiatipan",
                                "Xochicoatlan","Yahualica","Zacualtipan de angeles","Zapotlan de Juarez","Zempoala","Zimapan"};

        string[] JaliscoMun = {"Acatic","Acatlan de Juarez","Ahualulco de Mercado","Amacueca","Amatitan","Ameca","Arandas","Atemajac de Brizuela","Atengo","Atenguillo",
                                "Atotonilco el Alto","Atoyac","Autlan de Navarro","Ayotlan","Ayutla","Bolaños","Cabo Corrientes","Cañadas de Obregon","Casimiro Castillo",
                                "Chapala","Chimaltitan","Chiquilistlan","Cihuatlan","Cocula","Colotlan","Concepcion de Buenos Aires","Cuauitlan de Garcia Barragan",
                                "Cuautla","Cuquio","Degollado","Ejutla","El Arenal","El Grullo","El Limon","El Salto","Encarnacion de Diaz","Etzatlan","Gomez Farias",
                                "Guachinango","Guadalajara","Hostotipaquillo","Huejucar","Huejuquilla el Alto","Ixtlahuacan de los Membrillos","Ixtlahuacan del Rio",
                                "Jalostotitlan","Jamay","Jesus Maria","Jilotlan de los Dolores","Jocotepec","Juanacatlan","Juchitlan","La Barca","Lagos de Moreno",
                                "La Manzanilla de la Paz","La Huerta","Magdalena","Mascota","Mazamitla","Mexticacan","Mezquitic","Mixtlan","Ojuelos de Jalisco","Ocotlan",
                                "Pihuamo","Poncitlan","Puerto Vallarta","Quitupan","San Cristobal de la Barranca","San Diego de Alejandria","San Gabriel",
                                "San Ignacio Cerro Gordo ","San Juan de los Lagos","San Juanito de Escobedo","San Julian","San Marcos","San Martin de Bolaños",
                                "San Martin Hidalgo","San Miguel el Alto","San Sebastian del Oeste","Santa Maria de los angeles","Santa Maria del Oro","Sayula","Tala",
                                "Talpa de Allende","Tamazula de Gordiano","Tapalpa","Tecalitlan","Techaluta de Montenegro","Tecolotlan","Tenamaxtlan","Teocaltiche",
                                "Teocuitatlan de Corona","Tepatitlan de Morelos","Tequila","Teuchitlan","Tizapan el Alto","Tlajomulco de Zuñiga","Tlaquepaque","Toliman",
                                "Tomatlan","Tonala","Tonaya","Tonila","Totatiche","Tototlan","Tuxcacuesco","Tuxcueca","Tuxpan","Union de San Antonio","Union de Tula",
                                "Valle de Guadalupe","Valle de Juarez","Villa Corona","Villa Guerrero","Villa Hidalgo","Villa Purificacion","Yahualica de Gonzalez Gallo",
                                "Zacoalco de Torres","Zapopan","Zapotiltic","Zapotitlan de Vadillo","Zapotlan del Rey","Zapotlanejo ","Zapotlan el Grande"};

        string[] MexicoMun = {"Acambay","Acolman","Aculco","Almoloya de Alquisiras","Almoloya de Juarez","Almoloya del Rio","Amanalco","Amatepec","Amecameca","Apaxco",
                            "Atenco","Atizapan","Atizapan de Zaragoza","Atlacomulco","Atlautla","Axapusco","Ayapango","Calimaya","Capulhuac","Chalco","Chapa de Mota",
                            "Chapultepec","Chiautla","Chicoloapan","Chiconcuac","Chimalhuacan","Coacalco de Berriozabal","Coatepec Harinas","Cocotitlan","Coyotepec",
                            "Cuautitlan","Cuautitlan Izcalli","Donato Guerra","Ecatepec de Morelos","Ecatzingo","El Oro","Huehuetoca","Hueypoxtla","Huixquilucan",
                            "Isidro Fabela","Ixtapaluca","Ixtapan de la Sal","Ixtapan del Oro","Ixtlahuaca","Jaltenco","Jilotepec","Jilotzingo","Jiquipilco","Jocotitlan",
                            "Joquicingo","Juchitepec","La Paz","Lerma","Luvianos","Malinalco","Melchor Ocampo","Metepec","Mexicaltzingo","Morelos","Naucalpan de Juarez",
                            "Nextlalpan","Nezahualcoyotl","Nicolas Romero","Nopaltepec","Ocoyoacac","Ocuilan","Otumba","Otzoloapan","Otzolotepec","Ozumba","Papalotla",
                            "Polotitlan","Rayon","San Antonio la Isla","San Felipe del Progreso","San Jose del Rincon","San Martin de las Piramides","San Mateo Atenco",
                            "San Simon de Guerrero","Santo Tomas","Soyaniquilpan de Juarez","Sultepec","Tecamac","Tejupilco","Temamatla","Temascalapa","Temascalcingo",
                            "Temascaltepec","Temoaya","Tenancingo","Tenango del Aire","Tenango del Valle","Teoloyucan","Teotihuacan","Tepetlaoxtoc","Tepetlixpa",
                            "Tepotzotlan","Tequixquiac","Texcaltitlan","Texcalyacac","Texcoco","Tezoyuca","Tianguistenco","Timilpan","Tlalmanalco","Tlalnepantla de Baz",
                            "Tlatlaya","Toluca","Tonanitla","Tonatico","Tultepec","Tultitlan","Valle de Bravo","Valle de Chalco Solidaridad","Villa de Allende",
                            "Villa del Carbon","Villa Guerrero","Villa Victoria","Xalatlaco","Xonacatlan","Zacazonapan","Zacualpan","Zinacantepec","Zumpahuacan",
                            "Zumpango" };

        string[] MichoacanMun = {"Acuitzio","Aguililla","Alvaro Obregon","Angamacutiro","Angangueo","Apatzingan","Aporo","Aquila","Ario de Rosales","Arteaga Riseñas",
                                "Briseñas","Buenavista","Caracuaro","Charapan","Charo","Chavinda","Cheran","Chilchota","Chuinicuila","ChucAndiro","Churintzio",
                                "Churumuco","Coahuayana","CoalcomAn de Vazquez Pallares","Coeneo","Cojumatlan de Regules","Contepec","CopAndaro","Cotija","Cuitzeo",
                                "Escuandureo","Epitacio Huerta","Erongaricuaro","Gabriel Zamora","Hidalgo","Huandacareo","Huaniqueo","Huetamo","Huiramba","Indaparapeo",
                                "Irimbo","Ixtlan","Jacona","Jimenez","Jiquilpan","Jose Sixto Verduzco","Juarez","Jungapeo","La Huacana","La Piedad","Lagunillas",
                                "Lazaro Cardenas","Los Reyes","Madero","Maravatio","Marcos Castellanos","Morelia","Morelos","Mugica","Nahuatzen","Nocupetaro",
                                "Nuevo Parangaricutiro","Nuevo Urecho","Numaran","Ocampo","Pajacuaran","Panindicuaro","Paracho","Paracuaro","Patzcuaro","Penjamillo",
                                "Periban","Purepero","Puruandiro","Querendaro","Quiroga","Sahuayo","Salvador Escalante","San Lucas","Santa Ana Maya","Senguio",
                                "Susupuato","Tancitaro","Tangamandapio","Tangancicuaro","Tanhuato","Taretan","Tarimbaro","Tepalcatepec","Tingindin","Tingambato",
                                "Tiquicheo de Nicolas Romero","Tlalpujahua","Tlazazalca","Tocumbo","Tumbiscatio","Turicato","Tuxpan","Tuzantla","Tzintzuntzan","Tzitzio",
                                "Uruapan","Venustiano Carranza","Villamar","Vista Hermosa","Yurecuaro","Zacapu","Zamora","Zinaparo","Zinapecuaro","Ziracuaretiro",
                                "Zitacuaro"};

        string[] MorelosMun = {"Amacuzac","Atlatlahucan","Axochiapan","Ayala","Coatlan del Rio","Cuautla","Cuernavaca","Emiliano Zapata","Huitzilac","Jantetelco",
                                "Jiutepec","Jojutla","Jonacatepec","Mazatepec","Miacatlan","Ocuituco","Puente de Ixtla","Temixco","Temoac","Tepalcingo","Tepoztlan",
                                "Tetecala","Tetela del Volcan","Tlalnepantla","Tlaltizapan de Zapata","Tlaquiltenango","Tlayacapan","Totolapan","Xochitepec",
                                "Yautepec de Zaragoza","Yecapixtla","Zacatepec de Hidalgo","Zacualpan de Amilpas"};

        string[] NayaritMun = {"Acaponeta","Ahuacatlan","Amatlan de Cañas","Bahia de Banderas","Compostela","El Nayar","Huajicori","Ixtlan del Rio","Jala","La Yesca",
                            "Rosamorada","Ruiz","San Blas","San Pedro Lagunillas","Santa Maria del Oro","Santiago Ixcuintla","Tecuala","Tepic","Tuxpan","Xalisco"};

        string[] NuevoLeonMun = {"Abasolo","Agualeguas","Allende","Anahuac","Apodaca","Aramberri","Bustamante","Cadereyta Jimenez","Cerralvo","China","Cienega de Flores",
                                "Doctor Arroyo","Doctor Coss","Doctor Gonzalez","El Carmen","Galeana","Garcia","General Bravo","General Escobedo","General Teran",
                                "General Treviño","General Zaragoza","General Zuazua","Guadalupe","Hidalgo","Higueras","Hualahuises","Iturbide","Juarez",
                                "Lampazos de Naranjo","Linares","Los Aldamas","Los Herreras","Los Ramones","Marin","Melchor Ocampo","Mier y Noriega","Mina",
                                "Montemorelos","Monterrey","Paras","Pesqueria","Rayones","Sabinas Hidalgo","Salinas Victoria","San Nicolas de los Garza",
                                "San Pedro Garza Garcia","Santa Catarina","Santiago","Vallecillo","Villaldama"};

        string[] OaxacaMun = {"Abejones","Acatlan de Perez Figueroa","Animas Trujano","Asuncion Cacalotepec","Asuncion Cuyotepeji","Asuncion Ixtaltepec",
                            "Asuncion Nochixtlan","Asuncion Ocotlan","Asuncion Tlacolulita","Ayoquezco de Aldama","Ayotzintepec","Calihuala","Candelaria Loxicha",
                            "Capulalpam de Mendez","Chahuites","Chalcatongo de Hidalgo","Chiquihuitlan de Benito Juarez","Cienega de Zimatlan","Ciudad Ixtepec",
                            "Coatecas Altas","Coicoyan de las Flores","Concepcion Buenavista","Concepcion Papalo","Constancia del Rosario","Cosolapa","Cosoltepec",
                            "Cuilapam de Guerrero","Cuyamecalco Villa de Zaragoza","El Barrio de la Soledad","El Espinal","Eloxochitlan de Flores Magon",
                            "Fresnillo de Trujano","Guadalupe de Ramirez","Guadalupe Etla","Guelatao de Juarez","Guevea de Humboldt","Heroica Ciudad de Ejutla de Crespo",
                            "Heroica Ciudad de Huajuapan de Leon","Heroica Ciudad de Tlaxiaco","Huautepec","Huautla de Jimenez","Ixpantepec Nieves","Ixtlan de Juarez",
                            "Juchitan de Zaragoza","La Compañia","La Pe","La Reforma","La Trinidad Vista Hermosa","Loma Bonita","Magdalena Apasco","Magdalena Jaltepec",
                            "Magdalena Mixtepec","Magdalena Ocotlan","Magdalena Peñasco","Magdalena Teitipac","Magdalena Tequisistlan","Magdalena Tlacotepec",
                            "Magdalena Yodocono de Porfirio Diaz","Magdalena Zahuatlan","Mariscala de Juarez","Martires de Tacubaya","Matias Romero Avendaño",
                            "Mazatlan Villa de Flores","Mesones Hidalgo","Miahuatlan de Porfirio Diaz","Mixistlan de la Reforma","Monjas","Natividad","Nazareno Etla",
                            "Nejapa de Madero","Nuevo Zoquiapam","Oaxaca de Juarez","Ocotlan de Morelos","Pinotepa de Don Luis","Pluma Hidalgo","Putla Villa de Guerrero",
                            "Reforma de Pineda","Reyes Etla","Rojas de Cuauhtemoc","Salina Cruz","San Agustin Amatengo","San Agustin Atenango","San Agustin Chayuco",
                            "San Agustin de las Juntas","San Agustin Etla","San Agustin Loxicha","San Agustin Tlacotepec","San Agustin Yatareni",
                            "San Andres Cabecera Nueva","San Andres Dinicuiti","San Andres Huaxpaltepec","San Andres Huayapam","San Andres Ixtlahuaca",
                            "San Andres Lagunas","San Andres Nuxiño","San Andres Paxtlan","San Andres Sinaxtla","San Andres Solaga","San Andres Teotilalpam",
                            "San Andres Tepetlapa","San Andres Yaa","San Andres Zabache","San Andres Zautla","San Antonino Castillo Velasco","San Antonino el Alto",
                            "San Antonino Monteverde","San Antonio Acutla","San Antonio de la Cal","San Antonio Huitepec","San Antonio Nanahuatipam",
                            "San Antonio Sinicahua","San Antonio Tepetlapa","San Baltazar ChichicApam","San Baltazar Loxicha","San Baltazar Yatzachi el Bajo",
                            "San Bartolo Coyotepec","San Bartolo Soyaltepec","San Bartolo Yautepec","San Bartolome Ayautla","San Bartolome Loxicha",
                            "San Bartolome Quialana","San Bartolome Yucuañe","San Bartolome Zoogocho","San Bernardo Mixtepec","San Blas Atempa","San Carlos Yautepec",
                            "San Cristobal Amatlan","San Cristobal Amoltepec","San Cristobal Lachirioag","San Cristobal Suchixtlahuaca","San Dionisio del Mar",
                            "San Dionisio Ocotepec","San Dionisio OcotlAn","San Esteban Atatlahuca","San Felipe Jalapa de Diaz","San Felipe Tejalapam",
                            "San Felipe Usila","San Francisco CahuacuA","San Francisco Cajonos","San Francisco Chapulapa","San Francisco Chindua",
                            "San Francisco del Mar","San Francisco Huehuetlan","San Francisco Ixhuatan","San Francisco Jaltepetongo","San Francisco Lachigolo",
                            "San Francisco Logueche","San Francisco Nuxaño","San Francisco Ozolotepec","San Francisco Sola","San Francisco Telixtlahuaca",
                            "San Francisco Teopan","San Francisco Tlapancingo","San Gabriel Mixtepec","San Ildefonso AmatlAn","San Ildefonso Sola",
                            "San Ildefonso Villa Alta","San Jacinto Amilpas","San Jacinto Tlacotepec","San Jeronimo CoatlAn","San Jeronimo Silacayoapilla",
                            "San Jeronimo Sosola","San Jeronimo Taviche","San Jeronimo Tecoatl","San Jeronimo Tlacochahuaya","San Jorge Nuchita","San Jose Ayuquila",
                            "San Jose Chiltepec","San Jose del Peñasco","San Jose del Progreso","San Jose Estancia Grande","San Jose Independencia","San Jose Lachiguiri",
                            "San Jose Tenango","San Juan Achiutla","San Juan Atepec","San Juan Bautista Atatlahuca","San Juan Bautista Coixtlahuaca",
                            "San Juan Bautista CuicatlAn","San Juan Bautista Guelache","San Juan Bautista JayacatlAn","San Juan Bautista Lo de Soto",
                            "San Juan Bautista Suchitepec","San Juan Bautista Tlacoatzintepec","San Juan Bautista Tlachichilco","San Juan Bautista Tuxtepec",
                            "San Juan Bautista Valle Nacional","San Juan Cacahuatepec","San Juan Chicomezuchil","San Juan Chilateca","San Juan Cieneguilla",
                            "San Juan Coatzospam","San Juan Colorado","San Juan Comaltepec","San Juan Cotzocon","San Juan del Estado","San Juan de los Cues",
                            "San Juan del Rio","San Juan Diuxi","San Juan Evangelista Analco","San Juan Guelavia","San Juan Guichicovi","San Juan Ihualtepec",
                            "San Juan Juquila Mixes","San Juan Juquila Vijanos","San Juan Lachao","San Juan Lachigalla","San Juan Lajarcia","San Juan Lalana",
                            "San Juan Mazatlan","San Juan Mixtepec","distrito 08","San Juan Mixtepec"," distrito 26","San Juan Ñumi","San Juan Ozolotepec",
                            "San Juan Petlapa","San Juan Quiahije","San Juan Quiotepec","San Juan Sayultepec","San Juan Tabaa","San Juan Tamazola","San Juan Teita",
                            "San Juan Teitipac","San Juan Tepeuxila","San Juan Teposcolula","San Juan Yaee","San Juan Yatzona","San Juan Yucuita","San Lorenzo",
                            "San Lorenzo Albarradas","San Lorenzo Cacaotepec","San Lorenzo Cuaunecuiltitla","San Lorenzo Texmelucan","San Lorenzo Victoria",
                            "San Lucas Camotlan","San Lucas Ojitlan","San Lucas Quiavini","San Lucas ZoquiApam","San Luis Amatlan","San Marcial Ozolotepec",
                            "San Marcos Arteaga","San Martin de los Cansecos","San Martin Huamelulpam","San Martin Itunyoso","San Martin Lachila","San Martin Peras",
                            "San Martin Tilcajete","San Martin Toxpalan","San Martin Zacatepec","San Mateo Cajonos","San Mateo del Mar","San Mateo Etlatongo",
                            "San Mateo Nejapam","San Mateo Peñasco","San Mateo Piñas","San Mateo Rio Hondo","San Mateo Sindihui","San Mateo Tlapiltepec",
                            "San Mateo Yoloxochitlan","San Melchor Betaza","San Miguel Achiutla","San Miguel Ahuehuetitlan","San Miguel Aloapam","San Miguel Amatitlan",
                            "San Miguel Amatlan","San Miguel Coatlan","San Miguel Chicahua","San Miguel Chimalapa","San Miguel del Puerto","San Miguel del Rio",
                            "San Miguel Ejutla","San Miguel el Grande","San Miguel Huautla","San Miguel Mixtepec","San Miguel Panixtlahuaca","San Miguel Peras",
                            "San Miguel Piedras","San Miguel Quetzaltepec","San Miguel Santa Flor","San Miguel Soyaltepec","San Miguel Suchixtepec",
                            "San Miguel TecomatlAn","San Miguel Tenango","San Miguel Tequixtepec","San Miguel TilquiApam","San Miguel Tlacamama","San Miguel Tlacotepec",
                            "San Miguel Tulancingo","San Miguel Yotao","San Nicolas","San Nicolas Hidalgo","San Pablo Coatlan","San Pablo Cuatro Venados",
                            "San Pablo Etla","San Pablo Huitzo","San Pablo Huixtepec","San Pablo Macuiltianguis","San Pablo Tijaltepec","San Pablo Villa de Mitla",
                            "San Pablo Yaganiza","San Pedro Amuzgos","San Pedro Apostol","San Pedro Atoyac","San Pedro Cajonos","San Pedro Comitancillo",
                            "San Pedro Cocaltepec Cantaros","San Pedro el Alto","San Pedro Huamelula","San Pedro Huilotepec","San Pedro Ixcatlan","San Pedro Ixtlahuaca",
                            "San Pedro Jaltepetongo","San Pedro Jicayan","San Pedro Jocotipac","San Pedro Juchatengo","San Pedro Martir","San Pedro Martir Quiechapa",
                            "San Pedro Martir Yucuxaco","San Pedro Mixtepec","distrito 22","San Pedro Mixtepec","distrito 26","San Pedro Molinos","San Pedro Nopala",
                            "San Pedro Ocopetatillo","San Pedro Ocotepec","San Pedro Pochutla","San Pedro Quiatoni","San Pedro SochiApam","San Pedro Tapanatepec",
                            "San Pedro Taviche","San Pedro Teozacoalco","San Pedro Teutila","San Pedro TidaA","San Pedro Topiltepec","San Pedro TotolApam",
                            "San Pedro y San Pablo Ayutla","San Pedro y San Pablo Teposcolula","San Pedro y San Pablo Tequixtepec","San Pedro Yaneri","San Pedro Yolox",
                            "San Pedro Yucunama","San Raymundo Jalpan","San SebastiAn Abasolo","San SebastiAn CoatlAn","San SebastiAn Ixcapa","San SebastiAn Nicananduta",
                            "San Sebastian Rio Hondo","San Sebastian Tecomaxtlahuaca","San Sebastian Teitipac","San Sebastian Tutla","San Simon Almolongas",
                            "San Simon Zahuatlan  ","Santa Ana","Santa Ana Ateixtlahuaca","Santa Ana Cuauhtemoc","Santa Ana del Valle","Santa Ana Tavela",
                            "Santa Ana Tlapacoyan","Santa Ana Yareni","Santa Ana Zegache","Santa Catalina Quieri","Santa Catarina Cuixtla","Santa Catarina Ixtepeji",
                            "Santa Catarina Juquila","Santa Catarina Lachatao","Santa Catarina Loxicha","Santa Catarina MechoacAn","Santa Catarina Minas",
                            "Santa Catarina Quiane","Santa Catarina Quioquitani","Santa CatarinaTayata","Santa Catarina TicuA","Santa Catarina Yosonotu",
                            "Santa Catarina Zapoquila","Santa Cruz Acatepec","Santa Cruz Amilpas","Santa Cruz de Bravo","Santa Cruz Itundujia","Santa Cruz Mixtepec",
                            "Santa Cruz Nundaco","Santa Cruz Papalutla","Santa Cruz Tacache de Mina","Santa Cruz Tacahua","Santa Cruz Tayata","Santa Cruz Xitla",
                            "Santa Cruz Xoxocotlan","Santa Cruz Zenzontepec","Santa Gertrudis","Santa Ines del Monte","Santa Ines de Zaragoza","Santa Ines Yatzeche",
                            "Santa Lucia del Camino","Santa Lucia Miahuatlan","Santa Lucia Monteverde","Santa Lucia Ocotlan","Santa Magdalena Jicotlan",
                            "Santa Maria Alotepec","Santa Maria Apazco","Santa Maria Atzompa","Santa Maria Camotlan","Santa Maria Chachoapam","Santa Maria Chilchotla",
                            "Santa Maria Chimalapa","Santa Maria Colotepec","Santa Maria Cortijo","Santa Maria Coyotepec","Santa Maria del Rosario",
                            "Santa Maria del Tule","Santa Maria Ecatepec","Santa Maria Guelace","Santa Maria Guienagati","Santa Maria Huatulco",
                            "Santa Maria Huazolotitlan","Santa Maria Ipalapa","Santa Maria Ixcatlan","Santa Maria Jacatepec","Santa Maria Jalapa del Marques",
                            "Santa Maria Jaltianguis","Santa Maria la Asuncion","Santa Maria Lachixio","Santa Maria Mixtequilla","Santa Maria Nativitas",
                            "Santa Maria Nduayaco","Santa Maria Ozolotepec","Santa Maria Papalo","Santa Maria Peñoles","Santa Maria Petapa","Santa Maria Quiegolani",
                            "Santa Maria Sola","Santa Maria Tataltepec","Santa Maria Tecomavaca","Santa Maria Temaxcalapa","Santa Maria Temaxcaltepec",
                            "Santa Maria Teopoxco","Santa Maria Tepantlali","Santa Maria TexcatitlAn","Santa Maria Tlahuitoltepec","Santa Maria Tlalixtac",
                            "Santa Maria Tonameca","Santa Maria Totolapilla","Santa Maria Xadani","Santa Maria Yalina","Santa Maria Yavesia","Santa Maria Yolotepec",
                            "Santa Maria Yosoyua","Santa Maria Yucuhiti","Santa Maria Zacatepec","Santa Maria Zaniza","Santa Maria ZoquitlAn","Santiago Amoltepec",
                            "Santiago Apoala","Santiago Apostol","Santiago Astata","Santiago AtitlAn","Santiago Ayuquililla","Santiago Cacaloxtepec","Santiago CamotlAn",
                            "Santiago Chazumba","Santiago ChoApam","Santiago Comaltepec","Santiago del Rio","Santiago HuajolotitlAn","Santiago Huauclilla",
                            "Santiago IhuitlAn Plumas","Santiago Ixcuintepec","Santiago Ixtayutla","Santiago Jamiltepec","Santiago Jocotepec","Santiago Juxtlahuaca",
                            "Santiago Lachiguiri","Santiago Lalopa","Santiago Laollaga","Santiago Laxopa","Santiago Llano Grande","Santiago MatatlAn","Santiago Miltepec",
                            "Santiago Minas","Santiago Nacaltepec","Santiago Nejapilla","Santiago Niltepec","Santiago Nundiche","Santiago Nuyoo",
                            "Santiago Pinotepa Nacional","Santiago Suchilquitongo","Santiago Tamazola","Santiago Tapextla","Santiago Tenango","Santiago Tepetlapa",
                            "Santiago Tetepec","Santiago Texcalcingo","Santiago Textitlan","Santiago Tilantongo","Santiago Tillo","Santiago Tlazoyaltepec",
                            "Santiago Xanica","Santiago Xiacui","Santiago Yaitepec","Santiago Yaveo","Santiago Yolomecatl","Santiago Yosondua","Santiago Yucuyachi",
                            "Santiago Zacatepec","Santiago Zoochila","Santo Domingo Albarradas","Santo Domingo Armenta","Santo Domingo Chihuitan",
                            "Santo Domingo de Morelos","Santo Domingo Ingenio","Santo Domingo Ixcatlan","Santo Domingo Nuxaa","Santo Domingo Ozolotepec",
                            "Santo Domingo Petapa","Santo Domingo Roayaga","Santo Domingo Tehuantepec","Santo Domingo Teojomulco","Santo Domingo Tepuxtepec",
                            "Santo Domingo Tlatayapam","Santo Domingo Tomaltepec","Santo Domingo Tonala","Santo Domingo Tonaltepec","Santo Domingo Xagacia",
                            "Santo Domingo YanhuitlAn","Santo Domingo Yodohino","Santo Domingo Zanatepec","Santo TomAs Jalieza","Santo TomAs Mazaltepec",
                            "Santo Tomas Ocotepec","Santo Tomas Tamazulapan","Santos Reyes Nopala","Santos Reyes Papalo","Santos Reyes Tepejillo","Santos Reyes Yucuna",
                            "San Vicente Coatlan","San Vicente Lachixio","San Vicente Nuñu","Silacayoapam","Sitio de Xitlapehua","Soledad Etla",
                            "Tamazulapam del Espiritu Santo","Tanetze de Zaragoza","Taniche","Tataltepec de Valdes","Teococuilco de Marcos Perez",
                            "Teotitlan de Flores Magon","Teotitlan del Valle","Teotongo","Tepelmeme Villa de Morelos","TezoatlAn de Segura y Luna",
                            "Tlacolula de Matamoros","Tlacotepec Plumas","Tlalixtac de Cabrera","Totontepec Villa de Morelos","Trinidad Zaachila","Union Hidalgo",
                            "Valerio Trujano","Villa de Chilapa de Diaz","Villa de Etla","Villa de Tamazulapam del Progreso","Villa de Tututepec de Melchor Ocampo",
                            "Villa de Zaachila","Villa Diaz Ordaz","Villa Hidalgo","Villa Sola de Vega","Villa Talea de Castro","Villa Tejupam de la Union","Yaxe",
                            "Yogana","Yutanduchi de Guerrero","Zapotitlan del Rio","Zapotitlan Lagunas","Zapotitlan Palmas","Zimatlan de Alvarez"};

        string[] PueblaMun = {"Acajete","Acateno","Acatlan","Acatzingo","Acteopan","Ahuacatlan","Ahuatlan","Ahuazotepec","Ahuehuetitla","Ajalpan","Albino Zertuche",
                            "Aljojuca","Altepexi","Amixtlan","Amozoc","Aquixtla","Atempan","Atexcal","Atlequizayan","Atlixco","Atoyatempan","Atzala","AtzitzihuacAn",
                            "Atzitzintla","Axutla","Ayotoxco de Guerrero","Calpan","Caltepec","Camocuautla","Cañada Morelos","Caxhuacan","Chalchicomula de Sesma",
                            "Chapulco","Chiautla","Chiautzingo","Chichiquila","Chiconcuautla","Chietla","Chigmecatitlan","Chignahuapan","Chignautla","Chila",
                            "Chila de la Sal","Chilchotla","Chinantla","Coatepec","Coatzingo","Cohetzala","Cohuecan","Coronango","CoxcatlAn","Coyomeapan","Coyotepec",
                            "Cuapiaxtla de Madero","Cuautempan","Cuautinchan","Cuautlancingo","Cuayuca de Andradre","Cuetzalan del Progreso","Cuyoaco","Domingo Arenas",
                            "Eloxochitlan","Epatlan","Esperanza","Francisco Z. Mena","General Felipe Angeles","Guadalupe","Guadalupe Victoria","Hermenegildo Galeana",
                            "Honey","Huaquechula","Huatlatlauca","Huauchinango","Huehuetla","HuehuetlAn el Chico","HuehuetlAn el Grande","Huejotzingo","Hueyapan",
                            "Hueytamalco","Hueytlalpan","Huitzilan de Serdan","Huitziltepec","Ixcamilpa de Guerrero","Ixcaquixtla","IxtacamaxtitlAn","Ixtepec",
                            "Izucar de Matamoros","Jalpan","Jolalpan","Jonotla","Jopala","Juan C. Bonilla","Juan Galindo","Juan N. Mendez","Lafragua","Libres",
                            "Los Reyes de Juarez","Magdalena Tlatlauquitepec","Mazapiltepec de Juarez","Mixtla","Molcaxac","Naupan","Nauzontla","Nealtican",
                            "Nicolas Bravo","Nopalucan","Ocotepec","Ocoyucan","Olintla","Oriental","Pahuatlan","Palmar de Bravo","Pantepec","Petlalcingo","Piaxtla",
                            "Puebla de Zaragoza","Quecholac","Quimixtlan","Rafael Lara Grajales","San Andres Cholula","San Antonio Cañada",
                            "San Diego La Meza Tochimiltzingo","San Felipe Teotlalcingo","San Felipe Tepatlan","San Gabriel Chilac","San Gregorio Atzompa",
                            "San Jeronimo Tecuanipan","San Jeronimo Xayacatlan","San Jose Chiapa","San Jose Miahuatlan","San Juan Atenco","San Juan Atzompa",
                            "San Martin Texmelucan","San Martin Totoltepec","San Matias Tlalancaleca","San Miguel Ixtitlan","San Miguel Xoxtla",
                            "San Nicolas Buenos Aires","San NicolAs de los Ranchos","San Pablo Anicano","San Pedro Cholula","San Pedro Yeloixtlahuaca",
                            "San Salvador el Seco","San Salvador el Verde","San Salvador Huixcolotla","San Sebastian Tlacotepec","Santa Catarina Tlaltempan",
                            "San Ines Ahuatempan","Santa Isabel Cholula","Santiago Miahuatlan ","Santo TomAs Hueyotlipan","Soltepec","Tecali de Herrera",
                            "Tecamachalco","Tecomatlan","Tehuacan","Tehuitzingo","Tenampulco","Teopantlan","Teotlalco","Tepanco de Lopez","Tepango de Rodriguez",
                            "Tepatlaxco de Hidalgo","Tepeaca","Tepemaxalco","Tepeojuma","Tepetzintla","Tepexco","Tepexi de Rodriguez","Tepeyahualco",
                            "Tepeyahualco de Cuauhtemoc","Tetela de Ocampo","Teteles de Avila Castillo","Teziutlan","Tianguismanalco","Tilapa",
                            "Tlacotepec de Benito Juarez","Tlacuilotepec","Tlachichuca","Tlahuapan","Tlaltenango","Tlanepantla","Tlaola","Tlapacoya","Tlapanala",
                            "Tlatlauquitepec","Tlaxco","Tochimilco","Tochtepec","Totoltepec de Guerrero","Tulcingo","Tuzamapan de Galeana","Tzicatlacoyan",
                            "Venustiano Carranza","Vicente Guerrero","Xayacatlan de Bravo","Xicotepec","Xicotlan","Xiutetelco","Xochiapulco","Xochiltepec",
                            "Xochitlan de Vicente Suarez","XochitlAn Todos Santos","Yaonahuac","Yehualtepec","Zacapala","Zacapoaxtla","Zacatlan","Zapotitlan",
                            "Zapotitlan de Mendez","Zaragoza","Zautla","Zihuateutla","Zinacatepec","Zongozotla","Zoquiapan","Zoquitlan"};

        string[] QueretaroMun = {"Amealco de Bonfil","Arroyo Seco","Cadereyta de Montes","Colon","Corregidora","El Marques","Ezequiel Montes","Huimilpan",
                                "Jalpan de Serra","Landa de Matamoros","Pedro Escobedo","Peñamiller","Pinal de Amoles","Queretaro","San Joaquin","San Juan del Rio",
                                "Tequisquiapan","Toliman"};

        string[] QuintanaRooMun = {"Benito Juarez","Cozumel","Felipe Carrillo Puerto","Isla Mujeres","Jose Maria Morelos","Lazaro Cardenas","Othon P. Blanco",
                                    "Solidaridad","Tulum"};

        string[] SanLuisPotosiMun = {"Ahualulco","Alaquines","Aquismon","Armadillo de los Infante","Axtla de Terrazas","Cardenas","Catorce","Cedral","Cerritos",
                                    "Cerro de San Pedro","Charcas","Ciudad del Maiz","Ciudad Fernandez","Ciudad Valles","Coxcatlan","Ebano","El Naranjo","Guadalcazar",
                                    "Huehuetlan","Lagunillas","Matehuala","Matlapa","Mexquitic de Carmona","Moctezuma","Rayon","Rioverde","Salinas","San Antonio",
                                    "San Ciro de Acosta","San Luis Potosi","San Martin Chalchicuautla","San Nicolas Tolentino","Santa Catarina","Santa Maria del Rio",
                                    "Santo Domingo","San Vicente Tancuayalab","Soledad de Graciano Sanchez","Tamasopo","Tamazunchale","Tampacan","Tampamolon Corona",
                                    "Tamuin","Tancanhuitz de Santos","Tanlajas","Tanquian de Escobedo","Tierra Nueva","Vanegas","Venado","Villa de Arriaga",
                                    "Villa de Arista","Villa de Guadalupe","Villa de la Paz","Villa de Ramos","Villa de Reyes","Villa Hidalgo","Villa Juarez",
                                    "Xilitla","Zaragoza"};

        string[] SinaloaMun = {"Ahome","Angostura","Badiraguato","Choix","Concordia","Cosala","Culiacan","El Fuerte","Elota","El Rosario","Escuinapa","Guasave",
                                "Mazatlan","Mocorito","Navolato","Salvador Alvarado","San Ignacio","Sinaloa de Leyva"};

        string[] SonoraMun = {"Aconchi","Agua Prieta","Alamos","Altar","Arivechi","Arizpe","Atil","Bacadehuachi","Bacanora","Bacerac","Bacoachi","Bacum","Banamichi",
                            "Baviacora","Bavispe","Benito Juarez","Benjamin Hill","Caborca","Cajeme","Cananea","Carbo","Cocurpe","Cumpas","Divisaderos","Empalme",
                            "Etchojoa","Fronteras","General Plutarco Elias Calles","Granados","Guaymas","Hermosillo","Huachinera","Huasabas","Huatabampo","Huepac",
                            "Imuris","La Colorada","Magdalena","Mazatan","Moctezuma","Naco","Nacori Chico","Nacozari de Garcia","Navojoa","Nogales","Onavas","Opodepe",
                            "Oquitoa","Pitiquito","Puerto Peñasco","Quiriego","Rayon","Rosario","Sahuaripa","San Felipe de Jesus","San Ignacio Rio Muerto",
                            "San Javier","San Luis Rio Colorado","San Miguel de Horcasitas","San Pedro de la Cueva","Santa Ana","Santa Cruz","Saric","Soyopa",
                            "Suaqui Grande","Tepache","Trincheras","Tubutama","Ures","Villa Hidalgo","Villa Pesqueira","Yecora"};

        string[] TabascoMun = {"Balancan","Cardenas","Centla","Centro","Comalcalco","Cunduacan","Emiliano Zapata","Huimanguillo","Jalapa","Jalpa de Mendez","Jonuta",
                            "Macuspana","Nacajuca","Paraiso","Tacotalpa","Teapa","Tenosique"};

        string[] TamaulipasMun = {"Abasolo","Aldama","Altamira","Antiguo Morelos","Burgos","Bustamante","Camargo","Casas","Ciudad Madero","Cruillas","Gomez Farias",
                                "Gonzalez","Gemez","Guerrero","Gustavo Diaz Ordaz","Hidalgo","Jaumave","Jimenez","Llera","Mainero","Mante","Matamoros","Mendez","Mier",
                                "Miguel Aleman","Miquihuana","Nuevo Laredo","Nuevo Morelos","Ocampo","Padilla","Palmillas","Reynosa","Rio Bravo","San Carlos",
                                "San Fernando","San Nicolas","Soto La Marina","Tampico","Tula","Valle Hermoso","Victoria","Villagran","Xicotencatl"};

        string[] TlaxcalaMun = {"Acuamanala de Miguel Hidalgo","Altzayanca","Amaxac de Guerrero","Apetatitlan de Antonio Carvajal","Atlangatepec","Apizaco",
                                "Benito Juarez","Calpulalpan","Chiautempan","Contla de Juan Cuamatzi","Cuapiaxtla","Cuaxomulco","El Carmen Tequexquitla",
                                "Emiliano Zapata","Españita","Huamantla","Hueyotlipan","Ixtacuixtla de Mariano Matamoros","Ixtenco","La Magdalena Tlaltelulco",
                                "Lazaro Cardenas","Mazatecochco de Jose Maria Morelos","Muñoz de Domingo Arenas","Nanacamilpa de Mariano Arista","Nativitas","Panotla",
                                "Papalotla de Xicohtencatl","Sanctorum de Lazaro Cardenas","San Damian Texoloc","San Francisco Tetlanohcan","San Jeronimo Zacualpan",
                                "San Jose Teacalco","San Juan Huactzinco","San Lorenzo Axocomanitla","San Lucas Tecopilco","San Pablo del Monte","Santa Ana Nopalucan",
                                "Santa Apolonia Teacalco","Santa Catarina Ayometla","Santa Cruz Quilehtla","Santa Cruz Tlaxcala","Santa Isabel Xiloxoxtla","Tenancingo",
                                "Teolocholco","Tepetitla de Lardizabal","Tepeyanco","Terrenate","Tetla de la Solidaridad","Tetlatlahuca","Tlaxcala","Tlaxco","Tocatlan",
                                "Totolac","Tzompantepec","Xaloztoc","Xaltocan","Xicohtzinco","Yauhquemecan","Zacatelco","Zitlaltepec de Trinidad Sanchez Santos"};

        string[] VeracruzMun = {"Acajete","Acatlan","Acayucan","Actopan","Acula","Acultzingo","Agua Dulce","alamo Temapache","Alpatlahuac",
                                "Alto Lucero de Gutierrez Barrios","Altotonga","Alvarado","Amatitlan","Amatlan de los Reyes","angel R. Cabada","Apazapan","Aquila",
                                "Astacinga","Atlahuilco","Atoyac","Atzacan","Atzalan","Ayahualulco","Banderilla","Benito Juarez","Boca del Rio","Calcahualco",
                                "Camaron de Tejeda","Camerino Z. Mendoza","Carlos A. Carrillo","Carrillo Puerto","Castillo de Teayo","Catemaco","Cazones de Herrera",
                                "Cerro Azul","Chacaltianguis","Chalma","Chiconamel","Chiconquiaco","Chicontepec","Chinameca","Chinampa de Gorostiza","Chocaman",
                                "Chontla","Chumatlan","Citlaltepetl","Coacoatzintla","Coahuitlan","Coatepec","Coatzacoalcos","Coatzintla","Coetzala","Colipa","Comapa",
                                "Cordoba","Cosamaloapan de Carpio","Consautlan de Carvajal","Coscomatepec","Cosoleacaque","Cotaxtla","Coxquihui","Coyutla","Cuichapa",
                                "Cuitlahuac","El Higo","Emiliano Zapata","Espinal","Filomeno Mata","Fortin","Gutierrez Zamora","Hidalgotitlan","Huayacocotla",
                                "Hueyapan de Ocampo","Huiloapan de Cuauhtemoc","Ignacio de la Llave","Ilamatlan","Isla","Ixcatepec","Ixhuacan de los Reyes",
                                "Ixhuatlancillo","Ixhuatlan del Cafe","Ixhuatlan de Madero","Ixhuatlan del Sureste","Ixmatlahuacan","Ixtaczoquitlan","Jalacingo",
                                "Jalcomulco","Jaltipan","Jamapa","Jesus Carranza","Jilotepec","Jose Azueta","Juan Rodriguez Clara","Juchique de Ferrer","La Antigua",
                                "Landero y Coss","La Perla","Las Choapas","Las Minas","Las Vigas de Ramirez","Lerdo de Tejada","Los Reyes","Magdalena","Maltrata",
                                "Manlio Fabio Altamirano","Mariano Escobedo","Martinez de la Torre","Mecatlan","Mecayapan","Medellin","Miahuatlan","Minatitlan",
                                "Misantla","Mixtla de Altamirano","Moloacan","Nanchital de Lazaro Cardenas del Rio","Naolinco","Naranjal","Naranjos Amatlan","Nautla",
                                "Nogales","Oluta","Omealca","Orizaba","Otatitlan","Oteapan","Ozuluama de Mascañeras","Pajapan","Panuco","Papantla","Paso del Macho",
                                "Paso de Ovejas","Perote","Platon Sanchez","Playa Vicente","Poza Rica de Hidalgo","Pueblo Viejo","Puente Nacional","Rafael Delgado",
                                "Rafael Lucio","Rio Blanco","Saltabarranca","San Andres Tenejapan","San Andres Tuxtla","San Juan Evangelista","San Rafael",
                                "Santiago Sochiapan","Santiago Tuxtla","Sayula de Aleman","Soconusco","Sochiapa","Soledad Atzompa","Soledad de Doblado","Soteapan",
                                "Tamalin","Tamiahua","Tampico Alto","Tancoco","Tantima","Tantoyuca","Tatatila","Tatahuicapan de Juarez","Tecolutla","Tehuipango",
                                "Tempoal","Tenampa","Tenochtitlan","Teocelo","Tepatlaxco","Tepetlan","Tepetzintla","Tequila","Texcatepec","Texhuacan","Texistepec",
                                "Tezonapa","Tihuatlan","Tierra Blanca","Tlacojalpan","Tlacolulan","Tlacotalpan","Tlacotepec de Mejia","Tlachichilco","Tlalixcoyan",
                                "Tlalnelhuayocan","Tlaltetela","Tlapacoyan","Tlaquilpa","Tlilapan","Tomatlan","Tonayan","Totutla","Tres Valles","Tuxpan","Tuxtilla",
                                "ursulo Galvan","Uxpanapa","Vega de Alatorre","Veracruz","Villa Aldama","Xalapa","Xico","Xoxocotla","Yanga","Yecuatla","Zacualpan",
                                "Zaragoza","Zentla","Zongolica","Zontecomatlan","Zozocolco de Hidalgo"};

        string[] YucatanMun = {"Abala","Acanceh","Akil","Baca","Bokoba","Buctzotz","Cacalchen","Calotmul","Cansahcab","Cantamayec","Calestun","Cenotillo","Conkal",
                                "Cuncunul","Cuzama","Chacsinkin","Chankom","Chapab","Chemax","Chicxulub Pueblo","Chichimila","Chikindzonot","Chochola","Chumayel",
                                "Dzan","Dzemul","Dzidzantun","Dzilam de Bravo","Dzilam Gonzalez","Dzitas","Dzoncauich","Espita","Halacho","Hocaba","Hoctun","Homun",
                                "Huhi","Hunucma","Ixtil","Izamal","Kanasin","Kantunil","Kaua","Kinchil","Kopoma","Mama","Mani","Maxcanu","Mayapan","Merida","Mococha",
                                "Motul","Muna","Muxupip","Opichen","Oxkutzcab","Panaba","Peto","Progreso","Quintana Roo","Rio Lagartos","Sacalum","Samahil","Sanahcat",
                                "San Felipe","Santa Elena","Seye","Sinanche","Sotuta","Sucila","Sudzal","Suma de Hidalgo","Tahdziu","Tahmek","Teabo","Tecoh",
                                "Tekal de Venegas","Tekanto","Tekax","Tekit","Tekom","Telchac Pueblo","Telchac Puerto","Temax","Temozon","Tepakan","Tetiz","Teya",
                                "Ticul","Timucuy","Tinum","Tixcacalcupul","Tixkokob","Tixmehuac","Tixpehual","Tizimin","Tunkas","Tzucacab","Uayma","Ucu","Uman",
                                "Valladolid","Xocchel","Yaxcaba","Yaxkukul","Yobain"};

        string[] ZacatecasMun = {"Apozol","Apulco","Atolinga","Benito Juarez","Calera","Cañitas de Felipe Pescador","Concepcion del Oro","Cuauhtemoc","Chalchihuites",
                                "Fresnillo","Trinidad Garcia de la Cadena","Genaro Codina","General Enrique Estrada","General Francisco R. Murguia",
                                "El Plateado de Joaquin Amaro","El Salvador","General Panfilo Natera","Guadalupe","Huanusco","Jalpa","Jerez","Jimenez del Teul",
                                "Juan Aldama","Juchipila","Loreto","Luis Moya","Mazapil","Melchor Ocampo","Mezquital del Oro","Miguel Auza","Momax","Monte Escobedo",
                                "Morelos","Moyahua de Estrada","Nochistlan de Mejia","Noria de angeles","Ojocaliente","Panuco","Pinos","Rio Grande","Sain Alto",
                                "Santa Maria de la Paz","Sombrerete","Susticacan","Tabasco","Tepechitlan","Tepetongo","Teul de Gonzalez Ortega",
                                "Tlaltenango de Sanchez Roman","Trancoso","Valparaiso","Vetagrande","Villa de Cos","Villa Garcia","Villa Gonzalez Ortega",
                                "Villa Hidalgo","Villanueva","Zacatecas"};

        public MainWindow()
        {

            InitializeComponent();
<<<<<<< HEAD

=======
            
            //Alta _Alta = new Alta();
            //tbClaveInterna.Text = _Alta.getClaveInterna();
>>>>>>> origin/master
            tbNombre.Focus();

            for (int i = 0; i < turno.Length; i++)
            {
                cbTurno.Items.Add(turno[i]);
            }

            for (int i = 0; i < sector.Length; i++)
            {
                cbSector.Items.Add(sector[i]);
            }

            for (int i = 0; i < estados.Length; i++)
            {
                cbEstados.Items.Add(estados[i]);
            }
        }

        private void cbEstados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selection = cbEstados.SelectedItem.ToString();

            switch (selection)
            {
                case "Aguascalientes":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < AguascalientesMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(AguascalientesMun[i]);
                    }
                    break;

                case "Baja California":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < BajaCaliforniaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(BajaCaliforniaMun[i]);
                    }
                    break;

                case "Baja California Sur":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < BajaCaliforniaSMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(BajaCaliforniaSMun[i]);
                    }
                    break;
                case "Campeche":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < CampecheMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(CampecheMun[i]);
                    }
                    break;
                case "Coahuila":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < CoahuilaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(CoahuilaMun[i]);
                    }
                    break;
                case "Colima":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < ColimaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(ColimaMun[i]);
                    }
                    break;
                case "Chiapas":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < ChiapasMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(ChiapasMun[i]);
                    }
                    break;
                case "Ciudad de Mexico":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < CiudadDeMexicoMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(CiudadDeMexicoMun[i]);
                    }
                    break;
                case "Chihuahua":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < ChihuahuaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(ChihuahuaMun[i]);
                    }
                    break;
                case "Durango":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < DurangoMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(DurangoMun[i]);
                    }
                    break;
                case "Guanajuato":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < GuanajuatoMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(GuanajuatoMun[i]);
                    }
                    break;
                case "Guerrero":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < GuerreroMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(GuerreroMun[i]);
                    }
                    break;
                case "Hidalgo":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < HidalgoMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(HidalgoMun[i]);
                    }
                    break;
                case "Jalisco":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < JaliscoMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(JaliscoMun[i]);
                    }
                    break;
                case "Mexico":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < MexicoMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(MexicoMun[i]);
                    }
                    break;
                case "Michoacan":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < MichoacanMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(MichoacanMun[i]);
                    }
                    break;
                case "Morelos":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < MorelosMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(MorelosMun[i]);
                    }
                    break;
                case "Nayarit":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < NayaritMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(NayaritMun[i]);
                    }
                    break;
                case "Nuevo Leon":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < NuevoLeonMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(NuevoLeonMun[i]);
                    }
                    break;
                case "Oaxaca":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < OaxacaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(OaxacaMun[i]);
                    }
                    break;
                case "Puebla":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < PueblaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(PueblaMun[i]);
                    }
                    break;
                case "Queretaro":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < QueretaroMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(QueretaroMun[i]);
                    }
                    break;
                case "Quintana Roo":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < QuintanaRooMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(QuintanaRooMun[i]);
                    }
                    break;
                case "San Luis Potosi":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < SanLuisPotosiMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(SanLuisPotosiMun[i]);
                    }
                    break;
                case "Sinaloa":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < SinaloaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(SinaloaMun[i]);
                    }
                    break;
                case "Sonora":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < SonoraMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(SonoraMun[i]);
                    }
                    break;
                case "Tabasco":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < TabascoMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(TabascoMun[i]);
                    }
                    break;
                case "Tamaulipas":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < TamaulipasMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(TamaulipasMun[i]);
                    }
                    break;
                case "Tlaxcala":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < TlaxcalaMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(TlaxcalaMun[i]);
                    }
                    break;
                case "Veracruz":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < VeracruzMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(VeracruzMun[i]);
                    }
                    break;
                case "Yucatan":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < YucatanMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(YucatanMun[i]);
                    }
                    break;
                case "Zacatecas":
                    cbMunicipios.Items.Clear();
                    for (int i = 0; i < ZacatecasMun.Length; i++)
                    {
                        cbMunicipios.Items.Add(ZacatecasMun[i]);
                    }
                    break;
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Alta darAlta = new Alta();
            darAlta.Cliente();
        }

        private void btnLeftMenuHide_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        private void btnLeftMenuShow_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;
            }
        }

    }
}