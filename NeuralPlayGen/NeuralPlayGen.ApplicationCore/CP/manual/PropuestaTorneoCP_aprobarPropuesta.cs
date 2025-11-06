
using System;
using System.Text;

using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CEN.NeuralPlay;



/*PROTECTED REGION ID(usingNeuralPlayGen.ApplicationCore.CP.NeuralPlay_PropuestaTorneo_aprobarPropuesta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace NeuralPlayGen.ApplicationCore.CP.NeuralPlay
{
public partial class PropuestaTorneoCP : GenericBasicCP
{
public void AprobarPropuesta (int p_oid)
{
        /*PROTECTED REGION ID(NeuralPlayGen.ApplicationCore.CP.NeuralPlay_PropuestaTorneo_aprobarPropuesta) ENABLED START*/
        try
        {
                CPSession.SessionInitializeTransaction ();


                PropuestaTorneoCEN propuestaCEN = new PropuestaTorneoCEN (CPSession.UnitRepo.PropuestaTorneoRepository);
                TorneoCEN torneoCEN = new TorneoCEN (CPSession.UnitRepo.TorneoRepository);
                NotificacionCEN notificacionCEN = new NotificacionCEN (CPSession.UnitRepo.NotificacionRepository);



                PropuestaTorneoEN propuestaEN = propuestaCEN.ReadOID (p_oid);

                if (propuestaEN == null) {
                        throw new Exception ("Propuesta de torneo no encontrada");
                }


                int numVotos = propuestaEN.VotoTorneo.Count;


                int VOTOS_NECESARIOS_PARA_APROBAR = 10;

                if (numVotos >= VOTOS_NECESARIOS_PARA_APROBAR) {
                        if (propuestaEN.Comunidad == null || propuestaEN.Comunidad.Count == 0) {
                                throw new Exception ("La propuesta de torneo no está asociada a ninguna comunidad.");
                        }


                        foreach (ComunidadEN comunidad in propuestaEN.Comunidad) {
                                string nombreTorneo = propuestaEN.Nombre + " (" + comunidad.Nombre + ")";


                                torneoCEN.New_ (
                                        nombreTorneo,
                                        DateTime.Now.AddDays (7),
                                        "Las reglas son: ",
                                        true,
                                        comunidad.Id
                                        );
                        }




                        notificacionCEN.New_ (
                                Enumerated.NeuralPlay.TipoNotificacionEnum.UnionTorneo,
                                "Tu propuesta de torneo '" + propuestaEN.Nombre + "' ha sido aprobada!",
                                false,
                                DateTime.Now,
                                propuestaEN.Usuario.Id
                                );


                        propuestaEN.Estado = Enumerated.NeuralPlay.EstadoSolicitudEnum.Aceptada;
                }
                else{
                        propuestaEN.Estado = Enumerated.NeuralPlay.EstadoSolicitudEnum.Rechazada;
                }


                propuestaCEN.get_IPropuestaTorneoRepository ().Modify (propuestaEN);


                CPSession.Commit ();
        }
        catch (Exception ex)
        {
                CPSession.RollBack ();
                throw ex;
        }
        finally
        {
                CPSession.SessionClose ();
        }

        /*PROTECTED REGION END*/
}
}
}
