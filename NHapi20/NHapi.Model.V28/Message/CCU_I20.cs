using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V28.Group;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V28.Message

{
///<summary>
/// Represents a CCU_I20 message structure (see chapter 11.6.6). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (Message Header) </li>
///<li>1: SFT (Software Segment) optional repeating</li>
///<li>2: UAC (User Authentication Credential Segment) optional </li>
///<li>3: RF1 (Referral Information) </li>
///<li>4: CCU_I20_PROVIDER_CONTACT (a Group object) optional repeating</li>
///<li>5: CCU_I20_PATIENT (a Group object) optional repeating</li>
///<li>6: NK1 (Next of Kin / Associated Parties) optional repeating</li>
///<li>7: CCU_I20_INSURANCE (a Group object) optional repeating</li>
///<li>8: CCU_I20_APPOINTMENT_HISTORY (a Group object) optional repeating</li>
///<li>9: CCU_I20_CLINICAL_HISTORY (a Group object) optional repeating</li>
///<li>10: CCU_I20_PATIENT_VISITS (a Group object) repeating</li>
///<li>11: CCU_I20_MEDICATION_HISTORY (a Group object) optional repeating</li>
///<li>12: CCU_I20_PROBLEM (a Group object) optional repeating</li>
///<li>13: CCU_I20_GOAL (a Group object) optional repeating</li>
///<li>14: CCU_I20_PATHWAY (a Group object) optional repeating</li>
///<li>15: REL (Clinical Relationship Segment) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class CCU_I20 : AbstractMessage  {

	///<summary> 
	/// Creates a new CCU_I20 Group with custom IModelClassFactory.
	///</summary>
	public CCU_I20(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new CCU_I20 Group with DefaultModelClassFactory. 
	///</summary> 
	public CCU_I20() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for CCU_I20.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SFT), false, true);
	      this.add(typeof(UAC), false, false);
	      this.add(typeof(RF1), true, false);
	      this.add(typeof(CCU_I20_PROVIDER_CONTACT), false, true);
	      this.add(typeof(CCU_I20_PATIENT), false, true);
	      this.add(typeof(NK1), false, true);
	      this.add(typeof(CCU_I20_INSURANCE), false, true);
	      this.add(typeof(CCU_I20_APPOINTMENT_HISTORY), false, true);
	      this.add(typeof(CCU_I20_CLINICAL_HISTORY), false, true);
	      this.add(typeof(CCU_I20_PATIENT_VISITS), true, true);
	      this.add(typeof(CCU_I20_MEDICATION_HISTORY), false, true);
	      this.add(typeof(CCU_I20_PROBLEM), false, true);
	      this.add(typeof(CCU_I20_GOAL), false, true);
	      this.add(typeof(CCU_I20_PATHWAY), false, true);
	      this.add(typeof(REL), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CCU_I20 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SFT (Software Segment) - creates it if necessary
	///</summary>
	public SFT GetSFT() {
	   SFT ret = null;
	   try {
	      ret = (SFT)this.GetStructure("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SFT
	/// * (Software Segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SFT GetSFT(int rep) { 
	   return (SFT)this.GetStructure("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SFT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the SFT results 
	 */ 
	public IEnumerable<SFT> SFTs 
	{ 
		get
		{
			for (int rep = 0; rep < SFTRepetitionsUsed; rep++)
			{
				yield return (SFT)this.GetStructure("SFT", rep);
			}
		}
	}

	///<summary>
	///Adds a new SFT
	///</summary>
	public SFT AddSFT()
	{
		return this.AddStructure("SFT") as SFT;
	}

	///<summary>
	///Removes the given SFT
	///</summary>
	public void RemoveSFT(SFT toRemove)
	{
		this.RemoveStructure("SFT", toRemove);
	}

	///<summary>
	///Removes the SFT at the given index
	///</summary>
	public void RemoveSFTAt(int index)
	{
		this.RemoveRepetition("SFT", index);
	}

	///<summary>
	/// Returns UAC (User Authentication Credential Segment) - creates it if necessary
	///</summary>
	public UAC UAC { 
get{
	   UAC ret = null;
	   try {
	      ret = (UAC)this.GetStructure("UAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RF1 (Referral Information) - creates it if necessary
	///</summary>
	public RF1 RF1 { 
get{
	   RF1 ret = null;
	   try {
	      ret = (RF1)this.GetStructure("RF1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_PROVIDER_CONTACT (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_PROVIDER_CONTACT GetPROVIDER_CONTACT() {
	   CCU_I20_PROVIDER_CONTACT ret = null;
	   try {
	      ret = (CCU_I20_PROVIDER_CONTACT)this.GetStructure("PROVIDER_CONTACT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_PROVIDER_CONTACT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_PROVIDER_CONTACT GetPROVIDER_CONTACT(int rep) { 
	   return (CCU_I20_PROVIDER_CONTACT)this.GetStructure("PROVIDER_CONTACT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_PROVIDER_CONTACT 
	 */ 
	public int PROVIDER_CONTACTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROVIDER_CONTACT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_PROVIDER_CONTACT results 
	 */ 
	public IEnumerable<CCU_I20_PROVIDER_CONTACT> PROVIDER_CONTACTs 
	{ 
		get
		{
			for (int rep = 0; rep < PROVIDER_CONTACTRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_PROVIDER_CONTACT)this.GetStructure("PROVIDER_CONTACT", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_PROVIDER_CONTACT
	///</summary>
	public CCU_I20_PROVIDER_CONTACT AddPROVIDER_CONTACT()
	{
		return this.AddStructure("PROVIDER_CONTACT") as CCU_I20_PROVIDER_CONTACT;
	}

	///<summary>
	///Removes the given CCU_I20_PROVIDER_CONTACT
	///</summary>
	public void RemovePROVIDER_CONTACT(CCU_I20_PROVIDER_CONTACT toRemove)
	{
		this.RemoveStructure("PROVIDER_CONTACT", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_PROVIDER_CONTACT at the given index
	///</summary>
	public void RemovePROVIDER_CONTACTAt(int index)
	{
		this.RemoveRepetition("PROVIDER_CONTACT", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_PATIENT GetPATIENT() {
	   CCU_I20_PATIENT ret = null;
	   try {
	      ret = (CCU_I20_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_PATIENT
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_PATIENT GetPATIENT(int rep) { 
	   return (CCU_I20_PATIENT)this.GetStructure("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_PATIENT 
	 */ 
	public int PATIENTRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_PATIENT results 
	 */ 
	public IEnumerable<CCU_I20_PATIENT> PATIENTs 
	{ 
		get
		{
			for (int rep = 0; rep < PATIENTRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_PATIENT)this.GetStructure("PATIENT", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_PATIENT
	///</summary>
	public CCU_I20_PATIENT AddPATIENT()
	{
		return this.AddStructure("PATIENT") as CCU_I20_PATIENT;
	}

	///<summary>
	///Removes the given CCU_I20_PATIENT
	///</summary>
	public void RemovePATIENT(CCU_I20_PATIENT toRemove)
	{
		this.RemoveStructure("PATIENT", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_PATIENT at the given index
	///</summary>
	public void RemovePATIENTAt(int index)
	{
		this.RemoveRepetition("PATIENT", index);
	}

	///<summary>
	/// Returns  first repetition of NK1 (Next of Kin / Associated Parties) - creates it if necessary
	///</summary>
	public NK1 GetNK1() {
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.GetStructure("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NK1
	/// * (Next of Kin / Associated Parties) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NK1 GetNK1(int rep) { 
	   return (NK1)this.GetStructure("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NK1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NK1 results 
	 */ 
	public IEnumerable<NK1> NK1s 
	{ 
		get
		{
			for (int rep = 0; rep < NK1RepetitionsUsed; rep++)
			{
				yield return (NK1)this.GetStructure("NK1", rep);
			}
		}
	}

	///<summary>
	///Adds a new NK1
	///</summary>
	public NK1 AddNK1()
	{
		return this.AddStructure("NK1") as NK1;
	}

	///<summary>
	///Removes the given NK1
	///</summary>
	public void RemoveNK1(NK1 toRemove)
	{
		this.RemoveStructure("NK1", toRemove);
	}

	///<summary>
	///Removes the NK1 at the given index
	///</summary>
	public void RemoveNK1At(int index)
	{
		this.RemoveRepetition("NK1", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_INSURANCE (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_INSURANCE GetINSURANCE() {
	   CCU_I20_INSURANCE ret = null;
	   try {
	      ret = (CCU_I20_INSURANCE)this.GetStructure("INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_INSURANCE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_INSURANCE GetINSURANCE(int rep) { 
	   return (CCU_I20_INSURANCE)this.GetStructure("INSURANCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_INSURANCE 
	 */ 
	public int INSURANCERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("INSURANCE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_INSURANCE results 
	 */ 
	public IEnumerable<CCU_I20_INSURANCE> INSURANCEs 
	{ 
		get
		{
			for (int rep = 0; rep < INSURANCERepetitionsUsed; rep++)
			{
				yield return (CCU_I20_INSURANCE)this.GetStructure("INSURANCE", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_INSURANCE
	///</summary>
	public CCU_I20_INSURANCE AddINSURANCE()
	{
		return this.AddStructure("INSURANCE") as CCU_I20_INSURANCE;
	}

	///<summary>
	///Removes the given CCU_I20_INSURANCE
	///</summary>
	public void RemoveINSURANCE(CCU_I20_INSURANCE toRemove)
	{
		this.RemoveStructure("INSURANCE", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_INSURANCE at the given index
	///</summary>
	public void RemoveINSURANCEAt(int index)
	{
		this.RemoveRepetition("INSURANCE", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_APPOINTMENT_HISTORY (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_APPOINTMENT_HISTORY GetAPPOINTMENT_HISTORY() {
	   CCU_I20_APPOINTMENT_HISTORY ret = null;
	   try {
	      ret = (CCU_I20_APPOINTMENT_HISTORY)this.GetStructure("APPOINTMENT_HISTORY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_APPOINTMENT_HISTORY
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_APPOINTMENT_HISTORY GetAPPOINTMENT_HISTORY(int rep) { 
	   return (CCU_I20_APPOINTMENT_HISTORY)this.GetStructure("APPOINTMENT_HISTORY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_APPOINTMENT_HISTORY 
	 */ 
	public int APPOINTMENT_HISTORYRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("APPOINTMENT_HISTORY").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_APPOINTMENT_HISTORY results 
	 */ 
	public IEnumerable<CCU_I20_APPOINTMENT_HISTORY> APPOINTMENT_HISTORYs 
	{ 
		get
		{
			for (int rep = 0; rep < APPOINTMENT_HISTORYRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_APPOINTMENT_HISTORY)this.GetStructure("APPOINTMENT_HISTORY", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_APPOINTMENT_HISTORY
	///</summary>
	public CCU_I20_APPOINTMENT_HISTORY AddAPPOINTMENT_HISTORY()
	{
		return this.AddStructure("APPOINTMENT_HISTORY") as CCU_I20_APPOINTMENT_HISTORY;
	}

	///<summary>
	///Removes the given CCU_I20_APPOINTMENT_HISTORY
	///</summary>
	public void RemoveAPPOINTMENT_HISTORY(CCU_I20_APPOINTMENT_HISTORY toRemove)
	{
		this.RemoveStructure("APPOINTMENT_HISTORY", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_APPOINTMENT_HISTORY at the given index
	///</summary>
	public void RemoveAPPOINTMENT_HISTORYAt(int index)
	{
		this.RemoveRepetition("APPOINTMENT_HISTORY", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_CLINICAL_HISTORY (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_CLINICAL_HISTORY GetCLINICAL_HISTORY() {
	   CCU_I20_CLINICAL_HISTORY ret = null;
	   try {
	      ret = (CCU_I20_CLINICAL_HISTORY)this.GetStructure("CLINICAL_HISTORY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_CLINICAL_HISTORY
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_CLINICAL_HISTORY GetCLINICAL_HISTORY(int rep) { 
	   return (CCU_I20_CLINICAL_HISTORY)this.GetStructure("CLINICAL_HISTORY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_CLINICAL_HISTORY 
	 */ 
	public int CLINICAL_HISTORYRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CLINICAL_HISTORY").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_CLINICAL_HISTORY results 
	 */ 
	public IEnumerable<CCU_I20_CLINICAL_HISTORY> CLINICAL_HISTORYs 
	{ 
		get
		{
			for (int rep = 0; rep < CLINICAL_HISTORYRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_CLINICAL_HISTORY)this.GetStructure("CLINICAL_HISTORY", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_CLINICAL_HISTORY
	///</summary>
	public CCU_I20_CLINICAL_HISTORY AddCLINICAL_HISTORY()
	{
		return this.AddStructure("CLINICAL_HISTORY") as CCU_I20_CLINICAL_HISTORY;
	}

	///<summary>
	///Removes the given CCU_I20_CLINICAL_HISTORY
	///</summary>
	public void RemoveCLINICAL_HISTORY(CCU_I20_CLINICAL_HISTORY toRemove)
	{
		this.RemoveStructure("CLINICAL_HISTORY", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_CLINICAL_HISTORY at the given index
	///</summary>
	public void RemoveCLINICAL_HISTORYAt(int index)
	{
		this.RemoveRepetition("CLINICAL_HISTORY", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_PATIENT_VISITS (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_PATIENT_VISITS GetPATIENT_VISITS() {
	   CCU_I20_PATIENT_VISITS ret = null;
	   try {
	      ret = (CCU_I20_PATIENT_VISITS)this.GetStructure("PATIENT_VISITS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_PATIENT_VISITS
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_PATIENT_VISITS GetPATIENT_VISITS(int rep) { 
	   return (CCU_I20_PATIENT_VISITS)this.GetStructure("PATIENT_VISITS", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_PATIENT_VISITS 
	 */ 
	public int PATIENT_VISITSRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT_VISITS").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_PATIENT_VISITS results 
	 */ 
	public IEnumerable<CCU_I20_PATIENT_VISITS> PATIENT_VISITSs 
	{ 
		get
		{
			for (int rep = 0; rep < PATIENT_VISITSRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_PATIENT_VISITS)this.GetStructure("PATIENT_VISITS", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_PATIENT_VISITS
	///</summary>
	public CCU_I20_PATIENT_VISITS AddPATIENT_VISITS()
	{
		return this.AddStructure("PATIENT_VISITS") as CCU_I20_PATIENT_VISITS;
	}

	///<summary>
	///Removes the given CCU_I20_PATIENT_VISITS
	///</summary>
	public void RemovePATIENT_VISITS(CCU_I20_PATIENT_VISITS toRemove)
	{
		this.RemoveStructure("PATIENT_VISITS", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_PATIENT_VISITS at the given index
	///</summary>
	public void RemovePATIENT_VISITSAt(int index)
	{
		this.RemoveRepetition("PATIENT_VISITS", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_MEDICATION_HISTORY (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_MEDICATION_HISTORY GetMEDICATION_HISTORY() {
	   CCU_I20_MEDICATION_HISTORY ret = null;
	   try {
	      ret = (CCU_I20_MEDICATION_HISTORY)this.GetStructure("MEDICATION_HISTORY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_MEDICATION_HISTORY
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_MEDICATION_HISTORY GetMEDICATION_HISTORY(int rep) { 
	   return (CCU_I20_MEDICATION_HISTORY)this.GetStructure("MEDICATION_HISTORY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_MEDICATION_HISTORY 
	 */ 
	public int MEDICATION_HISTORYRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("MEDICATION_HISTORY").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_MEDICATION_HISTORY results 
	 */ 
	public IEnumerable<CCU_I20_MEDICATION_HISTORY> MEDICATION_HISTORYs 
	{ 
		get
		{
			for (int rep = 0; rep < MEDICATION_HISTORYRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_MEDICATION_HISTORY)this.GetStructure("MEDICATION_HISTORY", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_MEDICATION_HISTORY
	///</summary>
	public CCU_I20_MEDICATION_HISTORY AddMEDICATION_HISTORY()
	{
		return this.AddStructure("MEDICATION_HISTORY") as CCU_I20_MEDICATION_HISTORY;
	}

	///<summary>
	///Removes the given CCU_I20_MEDICATION_HISTORY
	///</summary>
	public void RemoveMEDICATION_HISTORY(CCU_I20_MEDICATION_HISTORY toRemove)
	{
		this.RemoveStructure("MEDICATION_HISTORY", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_MEDICATION_HISTORY at the given index
	///</summary>
	public void RemoveMEDICATION_HISTORYAt(int index)
	{
		this.RemoveRepetition("MEDICATION_HISTORY", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_PROBLEM (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_PROBLEM GetPROBLEM() {
	   CCU_I20_PROBLEM ret = null;
	   try {
	      ret = (CCU_I20_PROBLEM)this.GetStructure("PROBLEM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_PROBLEM
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_PROBLEM GetPROBLEM(int rep) { 
	   return (CCU_I20_PROBLEM)this.GetStructure("PROBLEM", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_PROBLEM 
	 */ 
	public int PROBLEMRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROBLEM").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_PROBLEM results 
	 */ 
	public IEnumerable<CCU_I20_PROBLEM> PROBLEMs 
	{ 
		get
		{
			for (int rep = 0; rep < PROBLEMRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_PROBLEM)this.GetStructure("PROBLEM", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_PROBLEM
	///</summary>
	public CCU_I20_PROBLEM AddPROBLEM()
	{
		return this.AddStructure("PROBLEM") as CCU_I20_PROBLEM;
	}

	///<summary>
	///Removes the given CCU_I20_PROBLEM
	///</summary>
	public void RemovePROBLEM(CCU_I20_PROBLEM toRemove)
	{
		this.RemoveStructure("PROBLEM", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_PROBLEM at the given index
	///</summary>
	public void RemovePROBLEMAt(int index)
	{
		this.RemoveRepetition("PROBLEM", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_GOAL (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_GOAL GetGOAL() {
	   CCU_I20_GOAL ret = null;
	   try {
	      ret = (CCU_I20_GOAL)this.GetStructure("GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_GOAL
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_GOAL GetGOAL(int rep) { 
	   return (CCU_I20_GOAL)this.GetStructure("GOAL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_GOAL 
	 */ 
	public int GOALRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GOAL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_GOAL results 
	 */ 
	public IEnumerable<CCU_I20_GOAL> GOALs 
	{ 
		get
		{
			for (int rep = 0; rep < GOALRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_GOAL)this.GetStructure("GOAL", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_GOAL
	///</summary>
	public CCU_I20_GOAL AddGOAL()
	{
		return this.AddStructure("GOAL") as CCU_I20_GOAL;
	}

	///<summary>
	///Removes the given CCU_I20_GOAL
	///</summary>
	public void RemoveGOAL(CCU_I20_GOAL toRemove)
	{
		this.RemoveStructure("GOAL", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_GOAL at the given index
	///</summary>
	public void RemoveGOALAt(int index)
	{
		this.RemoveRepetition("GOAL", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_PATHWAY (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_PATHWAY GetPATHWAY() {
	   CCU_I20_PATHWAY ret = null;
	   try {
	      ret = (CCU_I20_PATHWAY)this.GetStructure("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_PATHWAY
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_PATHWAY GetPATHWAY(int rep) { 
	   return (CCU_I20_PATHWAY)this.GetStructure("PATHWAY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_PATHWAY 
	 */ 
	public int PATHWAYRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATHWAY").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_PATHWAY results 
	 */ 
	public IEnumerable<CCU_I20_PATHWAY> PATHWAYs 
	{ 
		get
		{
			for (int rep = 0; rep < PATHWAYRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_PATHWAY)this.GetStructure("PATHWAY", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_PATHWAY
	///</summary>
	public CCU_I20_PATHWAY AddPATHWAY()
	{
		return this.AddStructure("PATHWAY") as CCU_I20_PATHWAY;
	}

	///<summary>
	///Removes the given CCU_I20_PATHWAY
	///</summary>
	public void RemovePATHWAY(CCU_I20_PATHWAY toRemove)
	{
		this.RemoveStructure("PATHWAY", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_PATHWAY at the given index
	///</summary>
	public void RemovePATHWAYAt(int index)
	{
		this.RemoveRepetition("PATHWAY", index);
	}

	///<summary>
	/// Returns  first repetition of REL (Clinical Relationship Segment) - creates it if necessary
	///</summary>
	public REL GetREL() {
	   REL ret = null;
	   try {
	      ret = (REL)this.GetStructure("REL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of REL
	/// * (Clinical Relationship Segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public REL GetREL(int rep) { 
	   return (REL)this.GetStructure("REL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of REL 
	 */ 
	public int RELRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("REL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the REL results 
	 */ 
	public IEnumerable<REL> RELs 
	{ 
		get
		{
			for (int rep = 0; rep < RELRepetitionsUsed; rep++)
			{
				yield return (REL)this.GetStructure("REL", rep);
			}
		}
	}

	///<summary>
	///Adds a new REL
	///</summary>
	public REL AddREL()
	{
		return this.AddStructure("REL") as REL;
	}

	///<summary>
	///Removes the given REL
	///</summary>
	public void RemoveREL(REL toRemove)
	{
		this.RemoveStructure("REL", toRemove);
	}

	///<summary>
	///Removes the REL at the given index
	///</summary>
	public void RemoveRELAt(int index)
	{
		this.RemoveRepetition("REL", index);
	}

}
}
