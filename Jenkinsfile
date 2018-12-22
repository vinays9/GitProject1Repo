pipeline{
    agent any
    stages{
        stage('Deploying to Development server'){
            steps{
               build 'WebApplication1-Develop'
            }
        }
		stage('Approve to deploy to Testing server?')
		{
			steps{
				timeout(time:2, unit:'DAYS')
				{
					input message: 'Can you approve to deploy to test server ??', submitter: 'vinay'
				}
			}
		}
        stage('Deploying to Testing server'){
            steps{
               build 'WebApplication-Stage'
            }
        }
		stage('Approve to deploy to Production server?')
		{
			steps{
				timeout(time:2, unit:'DAYS')
				{
					input message: 'Can you approve to deploy to production server ??', submitter: 'vinay'
				}
			}
		}
        stage('Deploying to Production server'){
            steps{
               build 'WebApplication1-Prod'
            }
        }
    }
}