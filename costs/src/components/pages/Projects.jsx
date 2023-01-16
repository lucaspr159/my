import Message from "../layout/Message"
import { useLocation } from "react-router-dom"
import styles from './Projects.module.css'
import Container from'../layout/Container'
import LinkButton from '../layout/LinkButton'
import ProjectCard from "../project/ProjectCard"
import { useState, useEffect } from "react"

function Projects(){
    const [projects, setProjects] = useState([])

    const location = useLocation()
    let message = ''
    if(location.state){
        message = location.state.message
    }

    useEffect(()=> {
        fetch('http://localhost:5000/projects',{
            method: 'GET',
            headers: {
                'Content-Type':'application/json',
            },
        })
        .then((resp) => resp.json())
        .then((data) => {
            console.log(data)
            setProjects(data)
        })
        .catch((err) => console.log(err))
    },[])

    return (
        <div className={styles.projectContainer}>
            <div className={styles.titleContainer}>
                <h1>Meus Projetos</h1>
                <LinkButton to='/newproject' text='Criar Projeto'/>  
            </div>
            {message && <Message type='success' msg={message}/>}
            <Container customClass="start">
                {projects.length > 0 && 
                    projects.map((project)=>(
                        <ProjectCard name={project.name}/>
                ))}
                

            </Container>
        </div>
    )
}
export default Projects