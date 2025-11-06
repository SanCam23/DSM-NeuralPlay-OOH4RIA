
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IMiembroEquipoRepository
{
void setSessionCP (GenericSessionCP session);

MiembroEquipoEN ReadOIDDefault (int id
                                );

void ModifyDefault (MiembroEquipoEN miembroEquipo);

System.Collections.Generic.IList<MiembroEquipoEN> ReadAllDefault (int first, int size);



int New_ (MiembroEquipoEN miembroEquipo);

void Modify (MiembroEquipoEN miembroEquipo);


void Destroy (int id
              );


MiembroEquipoEN ReadOID (int id
                         );


System.Collections.Generic.IList<MiembroEquipoEN> ReadAll (int first, int size);
}
}
