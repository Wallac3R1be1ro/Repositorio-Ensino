/*A herança permite a criação de novas classes a partir de outras previamente criadas,
tornando assim filhos delas. Essas novas classes são chamadas de subclasses, ou classes
derivadas; e as classes de origem são chamadas de superclasses ou classes base.*/
public class MyAppCarrosHeranca extends MyAppCarros{
	private final int MAX_ARMAMENTO=100;
	private final int MIN_ARMAMENTO=0;
	private int qtdearmamento;
	
	public MyAppCarrosHeranca(String nome,int blindagem){
		super(nome);
		setarmamento(true);
		setblindagem(blindagem);
		this.qtdearmamento=100;
	}
	
	public void setqtdearmamento(int qtdearmamento){
		this.qtdearmamento=qtdearmamento;
		if(this.qtdearmamento > MAX_ARMAMENTO){
			this.qtdearmamento=MAX_ARMAMENTO;
		}
		if(this.qtdearmamento < MIN_ARMAMENTO){
			this.qtdearmamento=MIN_ARMAMENTO;
		}
	}
	public int getqtdearmamento(){
		return this.qtdearmamento;
	}
	public void atirar(){
		if(this.qtdearmamento > MIN_ARMAMENTO){
			setqtdearmamento(-1);
		}else{
			System.out.println("Sem armamento");
		}
	}
	public void info(){
		super.info();
		System.out.printf("Qtde.Arm....:%d%n",this.qtdearmamento);
	}	
}