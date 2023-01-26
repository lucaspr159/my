import styles from './Project.module.css'
import {useParams} from 'react-router-dom'
import {useState, useEffect} from 'react'
import {parse, v4 as uuidv4} from 'uuid'

import Loading from '../layout/Loading'
import Container from '../layout/Container'
import ProjectForm from '../project/ProjectForm'
import Message from '../layout/Message'
import ServiceForm from '../service/ServiceForm'

function Project(){
    const {id} = useParams()
    
    const [project, setProject] = useState([])
    const [showProjectForm, setShowProjectForm] = useState(false)
    const [showServiceForm, setShowServiceForm] = useState(false)
    const [message, setMessage] = useState()
    const [type, setType] = useState()

    useEffect(() => {
        setTimeout(()=>{
            fetch(`http://localhost:5000/projects/${id}`, {
            method: 'GET',
            headers: {
                'Content-Type':'application/json',
            },
        })
        .then((resp) => resp.json())
        .then((data) => {
            setProject(data)
        })
        .catch((err) => console.log)
        },1000)
    }, [id])

    function editPost(project){
        setMessage()
        if(project.budget < project.cost){
            setMessage('O orçamento não pode ser menor que o custo do projeto!')
            setType('error')
            return(false)
        }
        fetch(`http://localhost:5000/projects/${project.id}`, {
            method:'PATCH',
            headers: {'Content-Type': 'application/json'
            },
            body: JSON.stringify(project),
        })
        .then(resp => resp.json())
        .then((data) =>{
            setProject(data)
            setShowProjectForm(false)
            setMessage('Projeto atualizado com sucesso!')
            setType('success')
        })
        .catch(err => console.log (err))
    }

    function creteService(){
        setMessage()
        //last service
        const lastService = project.services[project.services.length - 1]
        lastService.id = uuidv4()

        const lastServiceCost = lastService.cost
        const newCost = parseFloat(project.cost) + parseFloat(lastServiceCost)
        //maximum value validation
        if(newCost > parseFloat(project.budget)){
            setMessage('Orçamento ultrapassado, verifique o valor do serviço')
            setType('error')
            project.services.pop()
            return(false)
        }
        //add service cost to project total cost
        project.cost = newCost
        //update project
        fetch(`http://localhost:5000/projects/${project.id}`,{
            method:'PATCH',
            headers: {
                'Content-Type':'Application/json'
            },
            body: JSON.stringify(project)
        })
        .then((resp) => resp.json())
        .then((data) => {
            //exibir serviços
            console.log(data)
        })
        .catch(err => console.log(err))
    }
    function toggleProjectForm(){
        setShowProjectForm(!showProjectForm)
    }
    function toggleServiceForm(){
        setShowServiceForm(!showServiceForm)
    }

    return (
        <>
            {project.name ? (
                <div className={styles.projectDetails}>
                    <Container customClass="column">
                        {message && <Message type={type} msg={message}/>}
                        <div className={styles.detailsContainer}>
                            <h1>Projeto: {project.name}</h1>
                            <button onClick={toggleProjectForm} className={styles.btn}>
                                {!showProjectForm ? 'Editar projeto' : 'Fechar'}
                            </button>
                            {!showProjectForm ? (
                                <div className={styles.projectInfo}>
                                    <p>
                                        <span>Categoria:</span> {project.category.name}
                                    </p>
                                    <p>
                                        <span>Total de orçamento:</span> R${project.budget}
                                    </p>
                                    <p>
                                        <span>Total utilizado:</span> R${project.cost}
                                    </p>
                                </div>
                            ) : (
                                <div className={styles.projectInfo}>
                                    <ProjectForm handleSubmit={editPost} btnText='Concluir edição' projectData={project}/>
                                </div>
                            )}
                        </div>
                        <div className={styles.serviceFormContainer}>
                            <h2>Adicione um serviço</h2>
                            <button onClick={toggleServiceForm} className={styles.btn}>
                                {!showServiceForm ? 'Adicionar serviço' : 'Fechar'}
                            </button>
                            <div className={styles.projectInfo}>
                                {showServiceForm && (
                                    <ServiceForm
                                    handleSubmit={creteService}
                                    btnText='Adicionar serviço'
                                    projectData={project}
                                    />
                                )}
                            </div>
                        </div>
                        <h2>Serviços</h2>
                    <Container customClass="start">
                        <p> Itens de Serviços</p>

                    </Container>

                    </Container>
                </div>
            )  : (
                <Loading/>
            )}
        </>
    )
    
    
}
export default Project