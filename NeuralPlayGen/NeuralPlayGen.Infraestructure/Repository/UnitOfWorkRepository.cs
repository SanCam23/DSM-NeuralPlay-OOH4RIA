

using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;
using NeuralPlayGen.Infraestructure.Repository.NeuralPlay;
using NeuralPlayGen.Infraestructure.CP;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralPlayGen.Infraestructure.Repository
{
public class UnitOfWorkRepository : GenericUnitOfWorkRepository
{
SessionCPNHibernate session;


public UnitOfWorkRepository(SessionCPNHibernate session)
{
        this.session = session;
}

public override IParticipacionTorneoRepository ParticipacionTorneoRepository {
        get
        {
                this.participaciontorneorepository = new ParticipacionTorneoRepository ();
                this.participaciontorneorepository.setSessionCP (session);
                return this.participaciontorneorepository;
        }
}

public override ITorneoRepository TorneoRepository {
        get
        {
                this.torneorepository = new TorneoRepository ();
                this.torneorepository.setSessionCP (session);
                return this.torneorepository;
        }
}

public override IPropuestaTorneoRepository PropuestaTorneoRepository {
        get
        {
                this.propuestatorneorepository = new PropuestaTorneoRepository ();
                this.propuestatorneorepository.setSessionCP (session);
                return this.propuestatorneorepository;
        }
}

public override IVotoTorneoRepository VotoTorneoRepository {
        get
        {
                this.vototorneorepository = new VotoTorneoRepository ();
                this.vototorneorepository.setSessionCP (session);
                return this.vototorneorepository;
        }
}

public override ISesionRepository SesionRepository {
        get
        {
                this.sesionrepository = new SesionRepository ();
                this.sesionrepository.setSessionCP (session);
                return this.sesionrepository;
        }
}

public override IChatEquipoRepository ChatEquipoRepository {
        get
        {
                this.chatequiporepository = new ChatEquipoRepository ();
                this.chatequiporepository.setSessionCP (session);
                return this.chatequiporepository;
        }
}

public override IEquipoRepository EquipoRepository {
        get
        {
                this.equiporepository = new EquipoRepository ();
                this.equiporepository.setSessionCP (session);
                return this.equiporepository;
        }
}

public override IMiembroEquipoRepository MiembroEquipoRepository {
        get
        {
                this.miembroequiporepository = new MiembroEquipoRepository ();
                this.miembroequiporepository.setSessionCP (session);
                return this.miembroequiporepository;
        }
}

public override IMensajeChatRepository MensajeChatRepository {
        get
        {
                this.mensajechatrepository = new MensajeChatRepository ();
                this.mensajechatrepository.setSessionCP (session);
                return this.mensajechatrepository;
        }
}

public override IComunidadRepository ComunidadRepository {
        get
        {
                this.comunidadrepository = new ComunidadRepository ();
                this.comunidadrepository.setSessionCP (session);
                return this.comunidadrepository;
        }
}

public override ISolicitudIngresoRepository SolicitudIngresoRepository {
        get
        {
                this.solicitudingresorepository = new SolicitudIngresoRepository ();
                this.solicitudingresorepository.setSessionCP (session);
                return this.solicitudingresorepository;
        }
}

public override IInvitacionRepository InvitacionRepository {
        get
        {
                this.invitacionrepository = new InvitacionRepository ();
                this.invitacionrepository.setSessionCP (session);
                return this.invitacionrepository;
        }
}

public override IPublicacionRepository PublicacionRepository {
        get
        {
                this.publicacionrepository = new PublicacionRepository ();
                this.publicacionrepository.setSessionCP (session);
                return this.publicacionrepository;
        }
}

public override IComentarioRepository ComentarioRepository {
        get
        {
                this.comentariorepository = new ComentarioRepository ();
                this.comentariorepository.setSessionCP (session);
                return this.comentariorepository;
        }
}

public override IReaccionRepository ReaccionRepository {
        get
        {
                this.reaccionrepository = new ReaccionRepository ();
                this.reaccionrepository.setSessionCP (session);
                return this.reaccionrepository;
        }
}

public override INotificacionRepository NotificacionRepository {
        get
        {
                this.notificacionrepository = new NotificacionRepository ();
                this.notificacionrepository.setSessionCP (session);
                return this.notificacionrepository;
        }
}

public override IMiembroComunidadRepository MiembroComunidadRepository {
        get
        {
                this.miembrocomunidadrepository = new MiembroComunidadRepository ();
                this.miembrocomunidadrepository.setSessionCP (session);
                return this.miembrocomunidadrepository;
        }
}

public override IPerfilRepository PerfilRepository {
        get
        {
                this.perfilrepository = new PerfilRepository ();
                this.perfilrepository.setSessionCP (session);
                return this.perfilrepository;
        }
}

public override IJuegoRepository JuegoRepository {
        get
        {
                this.juegorepository = new JuegoRepository ();
                this.juegorepository.setSessionCP (session);
                return this.juegorepository;
        }
}

public override IPerfilJuegoRepository PerfilJuegoRepository {
        get
        {
                this.perfiljuegorepository = new PerfilJuegoRepository ();
                this.perfiljuegorepository.setSessionCP (session);
                return this.perfiljuegorepository;
        }
}

public override IUsuarioRepository UsuarioRepository {
        get
        {
                this.usuariorepository = new UsuarioRepository ();
                this.usuariorepository.setSessionCP (session);
                return this.usuariorepository;
        }
}
}
}

