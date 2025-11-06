
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface ISolicitudIngresoRepository
{
void setSessionCP (GenericSessionCP session);

SolicitudIngresoEN ReadOIDDefault (int id
                                   );

void ModifyDefault (SolicitudIngresoEN solicitudIngreso);

System.Collections.Generic.IList<SolicitudIngresoEN> ReadAllDefault (int first, int size);



int New_ (SolicitudIngresoEN solicitudIngreso);

void Modify (SolicitudIngresoEN solicitudIngreso);


void Destroy (int id
              );


SolicitudIngresoEN ReadOID (int id
                            );


System.Collections.Generic.IList<SolicitudIngresoEN> ReadAll (int first, int size);
}
}
