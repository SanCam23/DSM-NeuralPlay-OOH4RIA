
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CEN.NeuralPlay;
using NeuralPlayGen.Infraestructure.Repository.NeuralPlay;
using NeuralPlayGen.Infraestructure.CP;
using NeuralPlayGen.ApplicationCore.Exceptions;

using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;
using NeuralPlayGen.Infraestructure.Repository;
using NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception)
        {
                throw;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        try
        {
                // Initialising  CENs
                ParticipacionTorneoRepository participaciontorneorepository = new ParticipacionTorneoRepository ();
                ParticipacionTorneoCEN participaciontorneocen = new ParticipacionTorneoCEN (participaciontorneorepository);
                TorneoRepository torneorepository = new TorneoRepository ();
                TorneoCEN torneocen = new TorneoCEN (torneorepository);
                PropuestaTorneoRepository propuestatorneorepository = new PropuestaTorneoRepository ();
                PropuestaTorneoCEN propuestatorneocen = new PropuestaTorneoCEN (propuestatorneorepository);
                VotoTorneoRepository vototorneorepository = new VotoTorneoRepository ();
                VotoTorneoCEN vototorneocen = new VotoTorneoCEN (vototorneorepository);
                SesionRepository sesionrepository = new SesionRepository ();
                SesionCEN sesioncen = new SesionCEN (sesionrepository);
                ChatEquipoRepository chatequiporepository = new ChatEquipoRepository ();
                ChatEquipoCEN chatequipocen = new ChatEquipoCEN (chatequiporepository);
                EquipoRepository equiporepository = new EquipoRepository ();
                EquipoCEN equipocen = new EquipoCEN (equiporepository);
                MiembroEquipoRepository miembroequiporepository = new MiembroEquipoRepository ();
                MiembroEquipoCEN miembroequipocen = new MiembroEquipoCEN (miembroequiporepository);
                MensajeChatRepository mensajechatrepository = new MensajeChatRepository ();
                MensajeChatCEN mensajechatcen = new MensajeChatCEN (mensajechatrepository);
                ComunidadRepository comunidadrepository = new ComunidadRepository ();
                ComunidadCEN comunidadcen = new ComunidadCEN (comunidadrepository);
                SolicitudIngresoRepository solicitudingresorepository = new SolicitudIngresoRepository ();
                SolicitudIngresoCEN solicitudingresocen = new SolicitudIngresoCEN (solicitudingresorepository);
                InvitacionRepository invitacionrepository = new InvitacionRepository ();
                InvitacionCEN invitacioncen = new InvitacionCEN (invitacionrepository);
                PublicacionRepository publicacionrepository = new PublicacionRepository ();
                PublicacionCEN publicacioncen = new PublicacionCEN (publicacionrepository);
                ComentarioRepository comentariorepository = new ComentarioRepository ();
                ComentarioCEN comentariocen = new ComentarioCEN (comentariorepository);
                ReaccionRepository reaccionrepository = new ReaccionRepository ();
                ReaccionCEN reaccioncen = new ReaccionCEN (reaccionrepository);
                NotificacionRepository notificacionrepository = new NotificacionRepository ();
                NotificacionCEN notificacioncen = new NotificacionCEN (notificacionrepository);
                MiembroComunidadRepository miembrocomunidadrepository = new MiembroComunidadRepository ();
                MiembroComunidadCEN miembrocomunidadcen = new MiembroComunidadCEN (miembrocomunidadrepository);
                PerfilRepository perfilrepository = new PerfilRepository ();
                PerfilCEN perfilcen = new PerfilCEN (perfilrepository);
                JuegoRepository juegorepository = new JuegoRepository ();
                JuegoCEN juegocen = new JuegoCEN (juegorepository);
                PerfilJuegoRepository perfiljuegorepository = new PerfilJuegoRepository ();
                PerfilJuegoCEN perfiljuegocen = new PerfilJuegoCEN (perfiljuegorepository);
                UsuarioRepository usuariorepository = new UsuarioRepository ();
                UsuarioCEN usuariocen = new UsuarioCEN (usuariorepository);



                /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
                try
                {
                        Console.WriteLine ("--- INICIO INICIALIZACIÓN DE DATOS DE PRUEBA ---");

                        // =========================================================================
                        // 1. SETUP BÁSICO (Usuarios, Comunidades, Juegos, etc.) AQUI TAMBIEN SE PRUEBAN LOS CRUD CUSTOM
                        // =========================================================================
                        Console.WriteLine ("Creando datos maestros básicos...");

                        // --- INICIO DE LA CORRECCIÓN ---

                        // ==================== ADMIN ====================
                        Console.WriteLine ("Creando Perfil (Admin)...");
                        PerfilEN perfilAdminEN = new PerfilEN (){
                                FotoPerfilUrl = "default_avatar.png",
                                VisibilidadPerfil = VisibilidadEnum.Publico,
                                VisibilidadActividad = VisibilidadEnum.Publico,
                                Descripcion = "Perfil del Administrador",
                                JuegoFavorito = "Todos los juegos"
                        };
                        int perfilAdminId = perfilrepository.New_ (perfilAdminEN);
                        int userAdminId = usuariocen.New_ ("pass123", "AdminUser", "admin@neuralplay.com", "1234", DateTime.Now.AddYears (-25), perfilAdminId);
                        Console.WriteLine ("OK: Creado Admin (User ID: {userAdminId}, Perfil ID: {perfilAdminId})");


                        // ==================== LÍDER ====================
                        Console.WriteLine ("Creando Perfil (Líder)...");
                        PerfilEN perfilLiderEN = new PerfilEN (){
                                FotoPerfilUrl = "default_avatar.png",
                                VisibilidadPerfil = VisibilidadEnum.Publico,
                                VisibilidadActividad = VisibilidadEnum.Publico,
                                Descripcion = "Perfil del Líder",
                                JuegoFavorito = "Todos los juegos"
                        };
                        int perfilLiderId = perfilrepository.New_ (perfilLiderEN);
                        int userLiderId = usuariocen.New_ ("pass123", "LiderUser", "lider@neuralplay.com", "4555", DateTime.Now.AddYears (-20), perfilLiderId);
                        Console.WriteLine ("OK: Creado Líder (User ID: {userLiderId}, Perfil ID: {perfilLiderId})");


                        // ==================== MEMBER 1 ====================
                        Console.WriteLine ("Creando Perfil (Miembro 1)...");
                        PerfilEN perfilMember1EN = new PerfilEN (){
                                FotoPerfilUrl = "default_avatar.png",
                                VisibilidadPerfil = VisibilidadEnum.Publico,
                                VisibilidadActividad = VisibilidadEnum.Publico,
                                Descripcion = "Perfil del Miembro1",
                                JuegoFavorito = "Todos los juegos"
                        };
                        int perfilMember1Id = perfilrepository.New_ (perfilMember1EN);
                        int userMember1Id = usuariocen.New_ ("pass123", "Member1", "mem1@neuralplay.com", "8789", DateTime.Now.AddYears (-18), perfilMember1Id);
                        Console.WriteLine ("OK: Creado Member1 (User ID: {userMember1Id}, Perfil ID: {perfilMember1Id})");


                        // ==================== MEMBER 2 ====================
                        Console.WriteLine ("Creando Perfil (Miembro 2)...");
                        PerfilEN perfilMember2EN = new PerfilEN (){
                                FotoPerfilUrl = "default_avatar.png",
                                VisibilidadPerfil = VisibilidadEnum.Publico,
                                VisibilidadActividad = VisibilidadEnum.Publico,
                                Descripcion = "Perfil del Miembro2",
                                JuegoFavorito = "Todos los juegos"
                        };
                        int perfilMember2Id = perfilrepository.New_ (perfilMember2EN);
                        int userMember2Id = usuariocen.New_ ("pass123", "Member2", "mem2@neuralplay.com", "3421", DateTime.Now.AddYears (-22), perfilMember2Id);
                        Console.WriteLine ("OK: Creado Member2 (User ID: {userMember2Id}, Perfil ID: {perfilMember2Id})");


                        // ==================== BANNED USER ====================
                        Console.WriteLine ("Creando Perfil (Baneado)...");
                        PerfilEN perfilBannedEN = new PerfilEN (){
                                FotoPerfilUrl = "default_avatar.png",
                                VisibilidadPerfil = VisibilidadEnum.Publico,
                                VisibilidadActividad = VisibilidadEnum.Publico,
                                Descripcion = "Perfil del Baneado",
                                JuegoFavorito = "Todos los juegos"
                        };
                        int perfilBannedId = perfilrepository.New_ (perfilBannedEN);
                        int userBannedId = usuariocen.New_ ("pass123", "TrollUser", "troll@neuralplay.com", "1256", DateTime.Now.AddYears (-15), perfilBannedId);
                        Console.WriteLine ("OK: Creado Banned (User ID: {userBannedId}, Perfil ID: {perfilBannedId})");

                        // --- FIN DE LA CORRECCIÓN ---

                        // Crear Juego y Perfil de Juego
                        int propuestaBaseId = propuestatorneocen.New_ (
                                DateTime.Now,
                                EstadoSolicitudEnum.Pendiente,
                                -1, // No hay torneo aún
                                -1, // No hay equipo aún
                                userAdminId,
                                "Propuesta Base"
                                );
                        int juegoLoLId = juegocen.New_ ("League of Legends", GeneroJuegoEnum.Aventura);
                        int perfilJuegoId = perfiljuegocen.New_ (DateTime.Now, perfilMember1Id, juegoLoLId);

                        // Crear Comunidades
                        int comunidadGeneralId = comunidadcen.New_ ("Comunidad General", "Para todos los juegos", DateTime.Now, propuestaBaseId);
                        int comunidadLoLId = comunidadcen.New_ ("LoL España", "Solo para jugadores de LoL", DateTime.Now, propuestaBaseId);

                        // Crear Miembros de Comunidad Base (CRUD Custom: Crear miembro comunidad)
                        int mcLiderLoLId = miembrocomunidadcen.New_ (RolComunidadEnum.Lider, EstadoMembresiaEnum.Activa, DateTime.Now, comunidadLoLId, userLiderId);
                        // Este será ascendido luego
                        int mcFuturoLiderId = miembrocomunidadcen.New_ (RolComunidadEnum.Colaborador, EstadoMembresiaEnum.Activa, DateTime.Now, comunidadGeneralId, userMember1Id);


                        // =========================================================================
                        // 2. PRUEBAS DE MÉTODOS CUSTOM (CEN)
                        // =========================================================================
                        Console.WriteLine ("\n--- Pruebas Custom CEN ---");

                        // TEST: Ascender a Líder
                        Console.WriteLine ("Testing AscenderALider...");
                        miembrocomunidadcen.AscenderALider (mcFuturoLiderId);
                        if (miembrocomunidadcen.ReadOID (mcFuturoLiderId).Rol == RolComunidadEnum.Lider)
                                Console.WriteLine ("OK: Miembro ascendido a Líder correctamente.");
                        else
                                Console.WriteLine ("ERROR: Fallo al ascender miembro.");

                        // TEST: Actualizar Fecha Acción (PerfilJuego)
                        Console.WriteLine ("Testing ActualizarFechaAccion...");
                        DateTime fechaAntigua = perfiljuegocen.ReadOID (perfilJuegoId).FechaAccion ?? DateTime.MinValue;
                        System.Threading.Thread.Sleep (1000); // Pausa para asegurar cambio de segundo
                        perfiljuegocen.ActualizarFechaAccion (perfilJuegoId);
                        if (perfiljuegocen.ReadOID (perfilJuegoId).FechaAccion > fechaAntigua)
                                Console.WriteLine ("OK: Fecha de acción actualizada.");
                        else
                                Console.WriteLine ("ERROR: Fecha de acción no cambió.");

                        // TEST: Banear Miembro (requiere crear equipo y miembro primero)
                        Console.WriteLine ("Testing BanearMiembro...");
                        int equipoAlphaId = equipocen.New_ ("Alpha Team", "Equipo serio", DateTime.Now, comunidadLoLId, new List<int> { juegoLoLId });
                        int miembroBanId = miembroequipocen.New_ (RolEquipoEnum.Miembro, EstadoMembresiaEnum.Activa, DateTime.Now, equipoAlphaId, userBannedId);

                        miembroequipocen.BanearMiembro (miembroBanId);
                        if (miembroequipocen.ReadOID (miembroBanId).Estado == EstadoMembresiaEnum.Expulsada) // Usando 'Expulsada' según tu EN
                                Console.WriteLine ("OK: Miembro baneado (estado Expulsada).");
                        else
                                Console.WriteLine ("ERROR: El miembro no fue baneado correctamente.");


                        // =========================================================================
                        // 3. PRUEBAS TRANSACTIONAL (CP)
                        // =========================================================================
                        Console.WriteLine ("\n--- Pruebas Transactional CP ---");

                        // TEST: Aceptar Invitación
                        Console.WriteLine ("Testing CP AceptarInvitacion...");
                        int invitacionId = invitacioncen.New_ (TipoInvitacionEnum.Equipo, EstadoSolicitudEnum.Pendiente, DateTime.Now, comunidadLoLId, userLiderId);

                        InvitacionCP invitacionCP = new InvitacionCP (new SessionCPNHibernate ());
                        invitacionCP.AceptarInvitacion (invitacionId, userMember2Id);

                        // Verificaciones
                        bool invBorrada = invitacioncen.ReadOID (invitacionId) == null;
                        if (invBorrada)
                                Console.WriteLine ("OK: Invitacion aceptada y borrada.");
                        else
                                Console.WriteLine ("ERROR: La invitacion no se borra tras aceptar.");

                        // =========================================================================
                        // 4. PRUEBAS READFILTER
                        // =========================================================================
                        Console.WriteLine ("\n--- Pruebas ReadFilter ---");

                        Console.WriteLine ("\nCreando datos para pruebas de Torneos...");

                        int torneoTestId = torneocen.New_ ("Copa Verano LoL", DateTime.Now.AddDays (5), "Reglas: Solo nivel 30+", true, comunidadLoLId);

                        participaciontorneocen.New_ (EstadoParticipacionEnum.Aceptada, DateTime.Now, torneoTestId, equipoAlphaId);

                        IList<UsuarioEN> usuariosPorEquipo = usuariocen.DameUsuariosPorEquipo (equipoAlphaId);
                        Console.WriteLine ("consultamos los usuarios que estan en el equipo: " + equipoAlphaId);

                        foreach (UsuarioEN user in usuariosPorEquipo) {
                                Console.WriteLine ("Usuario ID: " + user.Id + " Nick: " + user.Nick);
                        }

                        IList<UsuarioEN> usuariosPorComunidad = usuariocen.DameUsuariosPorComunidad (comunidadLoLId);
                        Console.WriteLine ("Consultando usuarios de la comunidad ID: " + comunidadLoLId);

                        foreach (UsuarioEN user in usuariosPorComunidad) {
                                Console.WriteLine ("Usuario ID: " + user.Id + " | Nick: " + user.Nick);
                        }

                        IList<TorneoEN> torneosPorEquipo = torneocen.DameTorneosPorEquipo (equipoAlphaId);
                        Console.WriteLine ("Consultando torneos donde participa el equipo ID: " + equipoAlphaId);

                        foreach (TorneoEN torneo in torneosPorEquipo) {
                                Console.WriteLine ("Torneo ID: " + torneo.Id + " | Nombre: " + torneo.Nombre);
                        }

                        IList<EquipoEN> equiposPorTorneo = equipocen.DameEquiposPorTorneo (torneoTestId);
                        Console.WriteLine ("Consultando equipos inscritos en el torneo ID: " + torneoTestId);

                        foreach (EquipoEN equipo in equiposPorTorneo) {
                                Console.WriteLine ("Equipo ID: " + equipo.Id + " | Nombre: " + equipo.Nombre);
                        }

                        // =========================================================================
                        // TEST: Prueba de Validación de Privacidad del perfil (Debe fallar) (Prueba crud custom)
                        // =========================================================================
                        Console.WriteLine ("\n--- Test Validación Privacidad Perfil ---");
                        try
                        {
                                Console.WriteLine ("Intentando crear perfil inválido (Perfil Privado, Actividad Pública)...");
                                // Intentamos crear un perfil que rompe la regla:
                                // VisibilidadPerfil = Privado (Enum valor 2 según tu imagen)
                                // VisibilidadActividad = Publico (Enum valor 1)
                                perfilcen.New_ ("invalid.png",
                                        VisibilidadEnum.Privado,
                                        VisibilidadEnum.Publico,
                                        "Perfil que debería fallar",
                                        "Ninguno");

                                // Si llega aquí, es que NO ha saltado la excepción -> ERROR en la validación
                                Console.WriteLine ("ERROR: Se permitió crear un perfil con privacidad incoherente.");
                        }
                        catch (Exception ex)
                        {
                                // Si salta la excepción, es que la validación FUNCIONA -> OK
                                Console.WriteLine ("OK: La creación falló como se esperaba. Mensaje: " + ex.Message);
                        }

                        // =========================================================================
                        // TEST 6: Prueba Notificación por defecto no leída (Prueba crud custom)
                        // =========================================================================
                        Console.WriteLine("\n--- Test Notificación Leída=False por defecto ---");
                        try
                        {
                            // 1. Crear una notificación para un usuario existente (ej. Admin)
                            // Asegúrate de usar un tipo válido de tu Enum (ej. Sistema, Info, etc.)
                            int notifId = notificacioncen.New_(TipoNotificacionEnum.Sistema,"Bienvenido a NeuralPlay",DateTime.Now,userAdminId);

                            // 2. Recuperar la notificación de la BD
                            NotificacionEN notifRecuperada = notificacioncen.ReadOID(notifId);

                            // 3. Verificar que Leida es false
                            if (notifRecuperada.Leida == false)
                            {
                                Console.WriteLine("OK: La notificación se creó correctamente como NO LEÍDA.");
                            }
                            else
                            {
                                Console.WriteLine("ERROR: La notificación se creó como LEÍDA (true), debería ser false.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ERROR FATAL en Test Notificación: " + ex.Message);
                        }

                    Console.WriteLine ("\n--- FIN INICIALIZACIÓN ---");
                }
                catch (Exception ex)
                {
                        Console.WriteLine ("ERROR FATAL EN INITIALIZEDATA: " + ex.ToString ());
                        throw;
                }
                // You must write the initialisation of the entities inside the PROTECTED comments.
                // IMPORTANT:please do not delete them.

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw;
        }
}
}
}
