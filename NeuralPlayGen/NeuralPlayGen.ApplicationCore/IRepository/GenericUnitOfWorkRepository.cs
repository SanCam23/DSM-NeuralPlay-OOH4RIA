
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public abstract class GenericUnitOfWorkRepository
{
protected IParticipacionTorneoRepository participaciontorneorepository;
protected ITorneoRepository torneorepository;
protected IPropuestaTorneoRepository propuestatorneorepository;
protected IVotoTorneoRepository vototorneorepository;
protected ISesionRepository sesionrepository;
protected IChatEquipoRepository chatequiporepository;
protected IEquipoRepository equiporepository;
protected IMiembroEquipoRepository miembroequiporepository;
protected IMensajeChatRepository mensajechatrepository;
protected IComunidadRepository comunidadrepository;
protected ISolicitudIngresoRepository solicitudingresorepository;
protected IInvitacionRepository invitacionrepository;
protected IPublicacionRepository publicacionrepository;
protected IComentarioRepository comentariorepository;
protected IReaccionRepository reaccionrepository;
protected INotificacionRepository notificacionrepository;
protected IMiembroComunidadRepository miembrocomunidadrepository;
protected IPerfilRepository perfilrepository;
protected IJuegoRepository juegorepository;
protected IPerfilJuegoRepository perfiljuegorepository;
protected IUsuarioRepository usuariorepository;


public abstract IParticipacionTorneoRepository ParticipacionTorneoRepository {
        get;
}
public abstract ITorneoRepository TorneoRepository {
        get;
}
public abstract IPropuestaTorneoRepository PropuestaTorneoRepository {
        get;
}
public abstract IVotoTorneoRepository VotoTorneoRepository {
        get;
}
public abstract ISesionRepository SesionRepository {
        get;
}
public abstract IChatEquipoRepository ChatEquipoRepository {
        get;
}
public abstract IEquipoRepository EquipoRepository {
        get;
}
public abstract IMiembroEquipoRepository MiembroEquipoRepository {
        get;
}
public abstract IMensajeChatRepository MensajeChatRepository {
        get;
}
public abstract IComunidadRepository ComunidadRepository {
        get;
}
public abstract ISolicitudIngresoRepository SolicitudIngresoRepository {
        get;
}
public abstract IInvitacionRepository InvitacionRepository {
        get;
}
public abstract IPublicacionRepository PublicacionRepository {
        get;
}
public abstract IComentarioRepository ComentarioRepository {
        get;
}
public abstract IReaccionRepository ReaccionRepository {
        get;
}
public abstract INotificacionRepository NotificacionRepository {
        get;
}
public abstract IMiembroComunidadRepository MiembroComunidadRepository {
        get;
}
public abstract IPerfilRepository PerfilRepository {
        get;
}
public abstract IJuegoRepository JuegoRepository {
        get;
}
public abstract IPerfilJuegoRepository PerfilJuegoRepository {
        get;
}
public abstract IUsuarioRepository UsuarioRepository {
        get;
}
}
}
